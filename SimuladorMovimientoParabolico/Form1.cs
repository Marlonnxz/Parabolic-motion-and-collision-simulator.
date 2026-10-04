using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimuladorMovimientoParabolico
{
    public partial class Form1 : Form
    {
        private SimuladorFisico simulador = new SimuladorFisico();
        private bool enPausa = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipoGrafica.SelectedIndex = 2; // Por defecto: y vs. x (Trayectoria)
            InicializarSimulador(generarNuevoObjetivo: true);
            ActualizarVistaCompleta();
        }

        private bool ValidarEntradas(out double x0, out double y0, out double v0, out double angulo, out double g, out double dt)
        {
            x0 = 0; y0 = 0; v0 = 0; angulo = 0; g = 9.81; dt = 0.02;

            if (!double.TryParse(txtX0.Text.Trim().Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out x0) || x0 < 0 || x0 > 5000)
            {
                MostrarAlerta("Posición Inicial X0 inválida", "La posición inicial horizontal X0 debe ser un número entre 0 y 5000 metros.", txtX0);
                return false;
            }

            if (!double.TryParse(txtY0.Text.Trim().Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out y0) || y0 < 0 || y0 > 2000)
            {
                MostrarAlerta("Altura Inicial Y0 inválida", "La altura inicial Y0 debe ser un número entre 0 y 2000 metros (sobre el suelo).", txtY0);
                return false;
            }

            if (!double.TryParse(txtV0.Text.Trim().Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out v0) || v0 < 0.1 || v0 > 1000)
            {
                MostrarAlerta("Velocidad Inicial V0 inválida", "La magnitud de velocidad inicial V0 debe ser un valor positivo entre 0.1 y 1000 m/s.", txtV0);
                return false;
            }

            if (!double.TryParse(txtAngulo.Text.Trim().Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out angulo) || angulo < 0 || angulo >= 90)
            {
                MostrarAlerta("Ángulo inválido", "El ángulo de lanzamiento debe ser un valor entre 0° y 89.9° respecto a la horizontal.", txtAngulo);
                return false;
            }

            if (!double.TryParse(txtGravedad.Text.Trim().Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out g) || g <= 0.01 || g > 200)
            {
                MostrarAlerta("Gravedad inválida", "La aceleración gravitacional debe ser un valor positivo entre 0.01 y 200 m/s² (Tierra: 9.81).", txtGravedad);
                return false;
            }

            if (!double.TryParse(txtDt.Text.Trim().Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out dt) || dt < 0.001 || dt > 1.0)
            {
                MostrarAlerta("Paso temporal Δt inválido", "El paso temporal Δt debe estar entre 0.001 s (alta precisión) y 1.0 s para garantizar la estabilidad numérica.", txtDt);
                return false;
            }

            return true;
        }

        private void MostrarAlerta(string titulo, string mensaje, TextBox txtFoco)
        {
            lblEstado.Text = $"Estado: Entrada inválida ({titulo})";
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtFoco.SelectAll();
            txtFoco.Focus();
        }

        private bool InicializarSimulador(bool generarNuevoObjetivo = false)
        {
            if (!ValidarEntradas(out double x0, out double y0, out double v0, out double angulo, out double g, out double dt))
            {
                return false;
            }

            simulador.Configurar(x0, y0, v0, angulo, g, dt, generarNuevoObjetivo);
            return true;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            // Validar entradas antes de iniciar; si algo está mal, no arranca
            if (!InicializarSimulador(generarNuevoObjetivo: false))
            {
                return;
            }

            enPausa = false;
            btnPausar.Text = "Pausar";
            lblEstado.Text = "Estado: Simulación en curso";

            ActualizarResultadosTeoricos();
            ActualizarVariablesEnTiempoReal();
            ActualizarInfoObjetivo();
            ActualizarTablas();
            ActualizarGrafica();

            timer1.Start();
            picAnimacion.Invalidate();
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            if (simulador.SimulacionFinalizada) return;

            if (enPausa)
            {
                timer1.Start();
                enPausa = false;
                btnPausar.Text = "Pausar";
                lblEstado.Text = "Estado: Simulación en curso";
            }
            else
            {
                timer1.Stop();
                enPausa = true;
                btnPausar.Text = "Continuar";
                lblEstado.Text = "Estado: Pausado";
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            enPausa = false;
            btnPausar.Text = "Pausar";
            lblEstado.Text = "Estado: Reiniciado (Listo)";

            simulador.Reiniciar();
            ActualizarVistaCompleta();
        }

        private void btnNuevoObjetivo_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            enPausa = false;
            btnPausar.Text = "Pausar";
            lblEstado.Text = "Estado: Nuevo objetivo generado - Ajuste los parámetros para acertar";

            InicializarSimulador(generarNuevoObjetivo: true);
            ActualizarVistaCompleta();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool sigue = simulador.AvanzarPaso();

            ActualizarVariablesEnTiempoReal();
            picAnimacion.Invalidate();

            if (!sigue)
            {
                timer1.Stop();
                lblEstado.Text = "Estado: Simulación finalizada";
                ActualizarTablas();
                ActualizarGrafica();
            }
        }

        private void ActualizarVistaCompleta()
        {
            ActualizarResultadosTeoricos();
            ActualizarVariablesEnTiempoReal();
            ActualizarInfoObjetivo();
            ActualizarTablas();
            ActualizarGrafica();
            picAnimacion.Invalidate();
        }

        private void ActualizarVariablesEnTiempoReal()
        {
            lblTiempo.Text = $"Tiempo: {simulador.T:F3} s";
            lblPosicion.Text = $"Posición (x, y): ({simulador.X:F2}, {simulador.Y:F2}) m";
            lblVx.Text = $"Velocidad Vx: {simulador.Vx:F2} m/s";
            lblVy.Text = $"Velocidad Vy: {simulador.Vy:F2} m/s";
            lblVmag.Text = $"Magnitud |V|: {simulador.Vmag:F2} m/s";
            lblVang.Text = $"Ángulo θ: {simulador.Vang:F2} °";
        }

        private void ActualizarInfoObjetivo()
        {
            if (simulador.Objetivo != null)
            {
                bool intersecta = simulador.DeterminarSiTrayectoriaIntersecta(out double xCruce, out double tCruce);
                if (intersecta)
                {
                    lblInfoObjetivo.Text = $"Objetivo: X=[{simulador.Objetivo.XInicio:F1}-{simulador.Objetivo.XFin:F1}], Y={simulador.Objetivo.Y:F1}m (Intersecta: SÍ en X={xCruce:F1}m)";
                }
                else
                {
                    lblInfoObjetivo.Text = $"Objetivo: X=[{simulador.Objetivo.XInicio:F1}-{simulador.Objetivo.XFin:F1}], Y={simulador.Objetivo.Y:F1}m (Intersecta: NO)";
                }
            }
        }

        private void ActualizarResultadosTeoricos()
        {
            var t = simulador.Teorico;
            lblTeoHmax.Text = $"Altura Máxima: {t.AlturaMaxima:F2} m";
            lblTeoThmax.Text = $"Instante Hmáx: {t.TiempoAlturaMaxima:F2} s";
            lblTeoXhmax.Text = $"Posición X Hmáx: {t.PosXAlturaMaxima:F2} m";
            lblTeoTvuelo.Text = $"Tiempo de Vuelo: {t.TiempoVuelo:F2} s";
            lblTeoAlcance.Text = $"Alcance Total: {t.AlcanceHorizontal:F2} m";
            lblTeoVelHmax.Text = $"Vel. en Hmáx: Vx = {t.VelHMax_Vx:F1}, Vy = 0.0 m/s";
            lblTeoVelImpacto.Text = $"Vel. Impacto: Vx = {t.VelImpacto_Vx:F1}, Vy = {t.VelImpacto_Vy:F1} m/s";
            lblTeoVelImpactoMag.Text = $"Magnitud / Ángulo: |V| = {t.VelImpacto_Mag:F1} m/s, θ = {t.VelImpacto_Ang:F1}°";
        }

        private void ActualizarTablas()
        {
            // 1. Tabla de comparación teórico vs simulado
            dgvComparacion.Rows.Clear();
            var teo = simulador.Teorico;
            var sim = simulador.Simulado;

            AgregarFilaComparacion("Tiempo de vuelo primer tramo (s)", teo.TiempoVuelo, sim.TiempoVueloPrimerTramo);
            AgregarFilaComparacion("Altura máxima alcanzada (m)", teo.AlturaMaxima, sim.AlturaMaxima);
            AgregarFilaComparacion("Tiempo hasta altura máxima (s)", teo.TiempoAlturaMaxima, sim.TiempoAlturaMaxima);
            AgregarFilaComparacion("Alcance horizontal primer tramo (m)", teo.AlcanceHorizontal, sim.AlcancePrimerTramo);

            // 2. Tabla de eventos de colisión y rebotes
            dgvColisiones.Rows.Clear();
            foreach (var col in simulador.Colisiones)
            {
                dgvColisiones.Rows.Add(
                    col.Numero,
                    col.Tipo,
                    col.Tiempo.ToString("F3"),
                    col.X.ToString("F2"),
                    col.Y.ToString("F2"),
                    col.VxAntes.ToString("F2"),
                    col.VyAntes.ToString("F2"),
                    col.VmagAntes.ToString("F2"),
                    col.VangAntes.ToString("F1") + "°",
                    col.VxDespues.ToString("F2"),
                    col.VyDespues.ToString("F2"),
                    col.VmagDespues.ToString("F2"),
                    col.VangDespues.ToString("F1") + "°"
                );
            }
        }

        private void AgregarFilaComparacion(string metrica, double valTeorico, double valSimulado)
        {
            double difAbs = Math.Abs(valTeorico - valSimulado);
            double errorRel = (valTeorico != 0) ? (difAbs / Math.Abs(valTeorico)) * 100.0 : 0.0;

            dgvComparacion.Rows.Add(
                metrica,
                valTeorico.ToString("F4"),
                valSimulado.ToString("F4"),
                difAbs.ToString("F4"),
                errorRel.ToString("F2") + " %"
            );
        }

        private void cmbTipoGrafica_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarGrafica();
        }

        private void ActualizarGrafica()
        {
            if (chartGraficas.Series.Count < 2) return;

            Series sCurva = chartGraficas.Series["Curva"];
            Series sPuntos = chartGraficas.Series["PuntosClave"];
            ChartArea area = chartGraficas.ChartAreas[0];

            sCurva.Points.Clear();
            sPuntos.Points.Clear();

            int opcion = cmbTipoGrafica.SelectedIndex;
            if (opcion < 0) opcion = 2;

            // Configurar títulos de los ejes según la gráfica elegida
            switch (opcion)
            {
                case 0: // y vs. t
                    area.AxisX.Title = "Tiempo t (s)";
                    area.AxisY.Title = "Posición vertical y (m)";
                    sCurva.LegendText = "y(t)";
                    break;
                case 1: // x vs. t
                    area.AxisX.Title = "Tiempo t (s)";
                    area.AxisY.Title = "Posición horizontal x (m)";
                    sCurva.LegendText = "x(t)";
                    break;
                case 2: // y vs. x
                    area.AxisX.Title = "Posición horizontal x (m)";
                    area.AxisY.Title = "Posición vertical y (m)";
                    sCurva.LegendText = "Trayectoria y(x)";
                    break;
                case 3: // vx vs. t
                    area.AxisX.Title = "Tiempo t (s)";
                    area.AxisY.Title = "Velocidad horizontal vx (m/s)";
                    sCurva.LegendText = "vx(t)";
                    break;
                case 4: // vy vs. t
                    area.AxisX.Title = "Tiempo t (s)";
                    area.AxisY.Title = "Velocidad vertical vy (m/s)";
                    sCurva.LegendText = "vy(t)";
                    break;
                case 5: // |v| vs. t
                    area.AxisX.Title = "Tiempo t (s)";
                    area.AxisY.Title = "Magnitud de velocidad |v| (m/s)";
                    sCurva.LegendText = "|v|(t)";
                    break;
                case 6: // θ vs. t
                    area.AxisX.Title = "Tiempo t (s)";
                    area.AxisY.Title = "Ángulo de velocidad θ (grados)";
                    sCurva.LegendText = "θ(t)";
                    break;
            }

            sPuntos.LegendText = "Puntos Clave";

            if (simulador.Trayectoria == null || simulador.Trayectoria.Count == 0) return;

            try
            {
                // Llenar datos de la curva
                foreach (var p in simulador.Trayectoria)
                {
                    double px = 0.0, py = 0.0;
                    switch (opcion)
                    {
                        case 0: px = p.Tiempo; py = p.Y; break;
                        case 1: px = p.Tiempo; py = p.X; break;
                        case 2: px = p.X; py = p.Y; break;
                        case 3: px = p.Tiempo; py = p.Vx; break;
                        case 4: px = p.Tiempo; py = p.Vy; break;
                        case 5: px = p.Tiempo; py = p.Vmag; break;
                        case 6: px = p.Tiempo; py = p.Vang; break;
                    }
                    if (!double.IsNaN(px) && !double.IsInfinity(px) && !double.IsNaN(py) && !double.IsInfinity(py))
                    {
                        sCurva.Points.AddXY(px, py);
                    }
                }

                // Marcar Puntos Clave requeridos en la rúbrica (Altura máx, colisiones y rebotes)
                // 1. Altura máxima
                if (simulador.PuntoAlturaMax != null)
                {
                    var p = simulador.PuntoAlturaMax;
                    double px = 0.0, py = 0.0;
                    switch (opcion)
                    {
                        case 0: px = p.Tiempo; py = p.Y; break;
                        case 1: px = p.Tiempo; py = p.X; break;
                        case 2: px = p.X; py = p.Y; break;
                        case 3: px = p.Tiempo; py = p.Vx; break;
                        case 4: px = p.Tiempo; py = p.Vy; break;
                        case 5: px = p.Tiempo; py = p.Vmag; break;
                        case 6: px = p.Tiempo; py = p.Vang; break;
                    }
                    if (!double.IsNaN(px) && !double.IsInfinity(px) && !double.IsNaN(py) && !double.IsInfinity(py))
                    {
                        int idx = sPuntos.Points.AddXY(px, py);
                        sPuntos.Points[idx].Label = "Hmáx";
                    }
                }

                // 2. Eventos de Colisión
                foreach (var col in simulador.Colisiones)
                {
                    double px = 0.0, py = 0.0;
                    switch (opcion)
                    {
                        case 0: px = col.Tiempo; py = col.Y; break;
                        case 1: px = col.Tiempo; py = col.X; break;
                        case 2: px = col.X; py = col.Y; break;
                        case 3: px = col.Tiempo; py = col.VxAntes; break;
                        case 4: px = col.Tiempo; py = col.VyAntes; break;
                        case 5: px = col.Tiempo; py = col.VmagAntes; break;
                        case 6: px = col.Tiempo; py = col.VangAntes; break;
                    }
                    if (!double.IsNaN(px) && !double.IsInfinity(px) && !double.IsNaN(py) && !double.IsInfinity(py))
                    {
                        int idx = sPuntos.Points.AddXY(px, py);
                        sPuntos.Points[idx].Label = col.Tipo.Contains("Objetivo") ? "Impacto Obj" : $"Rebote {col.Numero}";
                    }
                }
            }
            catch
            {
                // Protección contra fallos inesperados de renderizado del control Chart
            }
        }

        private void picAnimacion_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int w = picAnimacion.ClientSize.Width;
            int h = picAnimacion.ClientSize.Height;

            int margenIzquierdo = 45;
            int margenInferior = 35;
            int margenSuperior = 20;
            int margenDerecho = 20;

            int anchoGrafico = w - margenIzquierdo - margenDerecho;
            int altoGrafico = h - margenInferior - margenSuperior;

            // Determinar dimensiones físicas máximas para ajustar escala
            double maxXFisico = Math.Max(simulador.Teorico.AlcanceHorizontal * 1.5, 60.0);
            double maxYFisico = Math.Max(simulador.Teorico.AlturaMaxima * 1.3, 30.0);

            if (simulador.Objetivo != null && simulador.Objetivo.XFin > maxXFisico)
            {
                maxXFisico = simulador.Objetivo.XFin * 1.2;
            }

            // Factor de escala: metros a píxeles
            double escalaX = (maxXFisico > 0) ? (anchoGrafico / maxXFisico) : 1.0;
            double escalaY = (maxYFisico > 0) ? (altoGrafico / maxYFisico) : 1.0;
            double escala = Math.Min(escalaX, escalaY); // Escala uniforme para no deformar la trayectoria
            if (double.IsNaN(escala) || double.IsInfinity(escala) || escala <= 1e-6) escala = 1.0;

            // Funciones locales para mapear coordenadas físicas (m) a píxeles de forma segura (sin desbordamiento)
            int MapX(double xFisico)
            {
                if (double.IsNaN(xFisico) || double.IsInfinity(xFisico)) return margenIzquierdo;
                double val = margenIzquierdo + (xFisico - simulador.X0) * escala;
                return (int)Math.Max(-10000, Math.Min(100000, val));
            }

            int MapY(double yFisico)
            {
                if (double.IsNaN(yFisico) || double.IsInfinity(yFisico)) return h - margenInferior;
                double val = h - margenInferior - (yFisico * escala);
                return (int)Math.Max(-10000, Math.Min(100000, val));
            }

            // 0. Fondo Cielo con Degradado Tecnológico Profundo
            using (LinearGradientBrush brushCielo = new LinearGradientBrush(
                new Point(0, 0),
                new Point(0, h),
                Color.FromArgb(11, 19, 43),
                Color.FromArgb(23, 37, 84)))
            {
                g.FillRectangle(brushCielo, 0, 0, w, h);
            }

            // 1. Dibujar Cuadrícula y Ejes
            using (Pen penGrid = new Pen(Color.FromArgb(30, 41, 59), 1))
            using (Pen penEjes = new Pen(Color.FromArgb(56, 189, 248), 1.5f))
            using (Font fontEjes = new Font("Segoe UI", 8.25F, FontStyle.Regular))
            using (Brush brushTexto = new SolidBrush(Color.FromArgb(148, 163, 184)))
            {
                int ySuelo = MapY(0);

                // Cuadrícula métrica
                double pasoX = Math.Max(10.0, Math.Round(maxXFisico / 6.0 / 5.0) * 5.0);
                double pasoY = Math.Max(5.0, Math.Round(maxYFisico / 5.0 / 5.0) * 5.0);

                for (double xVal = simulador.X0; xVal <= simulador.X0 + maxXFisico; xVal += pasoX)
                {
                    int px = MapX(xVal);
                    if (px >= margenIzquierdo && px <= w - margenDerecho)
                    {
                        g.DrawLine(penGrid, px, margenSuperior, px, ySuelo);
                        g.DrawString($"{xVal:0}m", fontEjes, brushTexto, px - 12, ySuelo + 6);
                    }
                }

                for (double yVal = 0; yVal <= maxYFisico; yVal += pasoY)
                {
                    int py = MapY(yVal);
                    if (py <= ySuelo && py >= margenSuperior)
                    {
                        g.DrawLine(penGrid, margenIzquierdo, py, w - margenDerecho, py);
                        g.DrawString($"{yVal:0}m", fontEjes, brushTexto, 6, py - 6);
                    }
                }

                // Ejes cartesianos principales
                g.DrawLine(penEjes, margenIzquierdo, margenSuperior, margenIzquierdo, ySuelo);

                // Suelo estilizado (Suelo Tecnológico Verde Neón con relleno profundo)
                using (Brush brushSuelo = new SolidBrush(Color.FromArgb(6, 78, 59)))
                using (Pen penSuelo = new Pen(Color.FromArgb(16, 185, 129), 3))
                {
                    g.FillRectangle(brushSuelo, margenIzquierdo, ySuelo, w - margenIzquierdo, h - ySuelo);
                    g.DrawLine(penSuelo, margenIzquierdo, ySuelo, w - margenDerecho, ySuelo);
                }

                using (Font fontSuelo = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold))
                using (Brush brushVerde = new SolidBrush(Color.FromArgb(52, 211, 153)))
                {
                    g.DrawString("Suelo (y = 0)", fontSuelo, brushVerde, w - 85, ySuelo - 18);
                }
            }

            // 2. Dibujar Objetivo Horizontal Aleatorio (Plataforma moderna)
            if (simulador.Objetivo != null)
            {
                int objX1 = MapX(simulador.Objetivo.XInicio);
                int objX2 = MapX(simulador.Objetivo.XFin);
                int objY = MapY(simulador.Objetivo.Y);
                int anchoObj = Math.Max(objX2 - objX1, 12);

                // Sombra de la plataforma
                using (Brush brushSombra = new SolidBrush(Color.FromArgb(50, 0, 0, 0)))
                {
                    g.FillRectangle(brushSombra, objX1 + 2, objY + 1, anchoObj, 8);
                }

                // Cuerpo de la plataforma (Rojo Rubí Luminoso)
                using (Brush brushObj = new SolidBrush(Color.FromArgb(239, 68, 68)))
                using (Pen penObj = new Pen(Color.FromArgb(254, 202, 202), 2))
                {
                    g.FillRectangle(brushObj, objX1, objY - 4, anchoObj, 8);
                    g.DrawRectangle(penObj, objX1, objY - 4, anchoObj, 8);
                }

                // Etiqueta distintiva sin emoji
                using (Font fontObj = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold))
                using (Brush brushObjText = new SolidBrush(Color.FromArgb(252, 165, 165)))
                {
                    g.DrawString("Objetivo", fontObj, brushObjText, objX1, objY - 18);
                }
            }

            // 3. Dibujar Trayectoria Recorrida
            if (simulador.Trayectoria != null && simulador.Trayectoria.Count > 1)
            {
                // Sombra / Resplandor neón de la estela
                using (Pen penSombra = new Pen(Color.FromArgb(60, 56, 189, 248), 5))
                {
                    for (int i = 0; i < simulador.Trayectoria.Count - 1; i++)
                    {
                        var p1 = simulador.Trayectoria[i];
                        var p2 = simulador.Trayectoria[i + 1];
                        g.DrawLine(penSombra, MapX(p1.X), MapY(p1.Y), MapX(p2.X), MapY(p2.Y));
                    }
                }

                // Línea principal de la parábola (Cian Neón Luminoso)
                using (Pen penTrayectoria = new Pen(Color.FromArgb(56, 189, 248), 2.5f))
                {
                    for (int i = 0; i < simulador.Trayectoria.Count - 1; i++)
                    {
                        var p1 = simulador.Trayectoria[i];
                        var p2 = simulador.Trayectoria[i + 1];
                        g.DrawLine(penTrayectoria, MapX(p1.X), MapY(p1.Y), MapX(p2.X), MapY(p2.Y));
                    }
                }
            }

            // 4. Dibujar Puntos de Impacto / Rebote en el Escenario (Anillos concéntricos de impacto)
            foreach (var col in simulador.Colisiones)
            {
                int cx = MapX(col.X);
                int cy = MapY(col.Y);

                using (Brush bAnillo = new SolidBrush(Color.FromArgb(249, 115, 22)))
                using (Brush bCentro = new SolidBrush(Color.FromArgb(254, 240, 138)))
                using (Pen pBorde = new Pen(Color.White, 1.5f))
                {
                    g.FillEllipse(bAnillo, cx - 6, cy - 6, 12, 12);
                    g.DrawEllipse(pBorde, cx - 6, cy - 6, 12, 12);
                    g.FillEllipse(bCentro, cx - 3, cy - 3, 6, 6);
                }
            }

            // 5. Dibujar la Partícula / Objeto Actual (Esfera 3D con brillo)
            int partX = MapX(simulador.X);
            int partY = MapY(simulador.Y);
            int radioParticula = 8;

            // Halo exterior luminiscente
            using (Brush brushHalo = new SolidBrush(Color.FromArgb(90, 56, 189, 248)))
            {
                g.FillEllipse(brushHalo, partX - radioParticula - 4, partY - radioParticula - 4, (radioParticula + 4) * 2, (radioParticula + 4) * 2);
            }

            // Esfera principal
            using (Brush brushPart = new SolidBrush(Color.FromArgb(14, 165, 233)))
            using (Pen penBorde = new Pen(Color.White, 2f))
            {
                g.FillEllipse(brushPart, partX - radioParticula, partY - radioParticula, radioParticula * 2, radioParticula * 2);
                g.DrawEllipse(penBorde, partX - radioParticula, partY - radioParticula, radioParticula * 2, radioParticula * 2);
            }

            // Punto de brillo especular
            using (Brush brushBrillo = new SolidBrush(Color.White))
            {
                g.FillEllipse(brushBrillo, partX - 4, partY - 5, 3, 3);
            }

            // Vector velocidad actual dibujado sobre la partícula (Amarillo Ámbar Neón)
            if (simulador.Vmag > 0.1)
            {
                double factorVector = 0.65; // Longitud proporcional
                int vxFin = partX + (int)(simulador.Vx * factorVector);
                int vyFin = partY - (int)(simulador.Vy * factorVector);
                using (Pen penVector = new Pen(Color.FromArgb(251, 191, 36), 2.5f))
                {
                    penVector.CustomEndCap = new AdjustableArrowCap(4, 6);
                    g.DrawLine(penVector, partX, partY, vxFin, vyFin);
                }
            }
        }

    }
}
