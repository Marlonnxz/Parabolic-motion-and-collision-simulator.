using System;
using System.Collections.Generic;

namespace SimuladorMovimientoParabolico
{
    public class PuntoTrayectoria
    {
        public double Tiempo { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Vx { get; set; }
        public double Vy { get; set; }
        public double Vmag { get; set; }
        public double Vang { get; set; }
    }

    public class ColisionRegistro
    {
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public double Tiempo { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double VxAntes { get; set; }
        public double VyAntes { get; set; }
        public double VmagAntes { get; set; }
        public double VangAntes { get; set; }
        public double VxDespues { get; set; }
        public double VyDespues { get; set; }
        public double VmagDespues { get; set; }
        public double VangDespues { get; set; }
    }

    public class ObjetivoHorizontal
    {
        public double XInicio { get; set; }
        public double XFin { get; set; }
        public double Y { get; set; }

        public bool ContieneX(double x, double tolerancia = 0.25)
        {
            double min = Math.Min(XInicio, XFin) - tolerancia;
            double max = Math.Max(XInicio, XFin) + tolerancia;
            return x >= min && x <= max;
        }
    }

    public class ResultadosTeoricos
    {
        public double TiempoVuelo { get; set; }
        public double AlturaMaxima { get; set; }
        public double TiempoAlturaMaxima { get; set; }
        public double PosXAlturaMaxima { get; set; }
        public double AlcanceHorizontal { get; set; }

        public double VelHMax_Vx { get; set; }
        public double VelHMax_Vy { get; set; }
        public double VelHMax_Mag { get; set; }
        public double VelHMax_Ang { get; set; }

        public double VelImpacto_Vx { get; set; }
        public double VelImpacto_Vy { get; set; }
        public double VelImpacto_Mag { get; set; }
        public double VelImpacto_Ang { get; set; }
    }

    public class ResultadosSimulados
    {
        public double TiempoVueloPrimerTramo { get; set; }
        public double AlturaMaxima { get; set; }
        public double TiempoAlturaMaxima { get; set; }
        public double AlcancePrimerTramo { get; set; }
    }

    public class SimuladorFisico
    {
        // Parámetros iniciales
        public double X0 { get; private set; }
        public double Y0 { get; private set; }
        public double V0 { get; private set; }
        public double AnguloGrad { get; private set; }
        public double Gravedad { get; private set; }
        public double Dt { get; private set; }

        // Estado actual de la partícula
        public double T { get; private set; }
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Vx { get; private set; }
        public double Vy { get; private set; }
        public double Vmag => Math.Sqrt(Vx * Vx + Vy * Vy);
        public double Vang => Math.Atan2(Vy, Vx) * (180.0 / Math.PI);

        // Objetivo horizontal fijo
        public ObjetivoHorizontal Objetivo { get; private set; }

        // Control de rebotes
        private bool huboColisionObjetivo = false;
        private int conteoRebotesSuelo = 0;
        private int maxRebotesSueloPermitidos = 2;

        public bool SimulacionFinalizada { get; private set; }

        // Historiales
        public List<PuntoTrayectoria> Trayectoria { get; private set; }
        public List<ColisionRegistro> Colisiones { get; private set; }

        // Puntos clave detectados para graficar
        public PuntoTrayectoria PuntoAlturaMax { get; private set; }
        public ColisionRegistro EventoColisionObjetivo { get; private set; }
        public ColisionRegistro EventoRebote1Suelo { get; private set; }
        public ColisionRegistro EventoRebote2Suelo { get; private set; }

        // Resultados
        public ResultadosTeoricos Teorico { get; private set; }
        public ResultadosSimulados Simulado { get; private set; }

        private double maxYSegundoTramo = 0.0;
        private double tiempoMaxYSegundoTramo = 0.0;

        private static readonly Random rand = new Random();

        public SimuladorFisico()
        {
            Trayectoria = new List<PuntoTrayectoria>();
            Colisiones = new List<ColisionRegistro>();
            Objetivo = new ObjetivoHorizontal();
            Teorico = new ResultadosTeoricos();
            Simulado = new ResultadosSimulados();
            SimulacionFinalizada = false;
        }

        public void Configurar(double x0, double y0, double v0, double anguloGrad, double gravedad, double dt, bool generarNuevoObjetivo = false)
        {
            X0 = x0;
            Y0 = y0;
            V0 = v0;
            AnguloGrad = anguloGrad;
            Gravedad = gravedad;
            Dt = dt;

            CalcularModeloTeorico();
            if (generarNuevoObjetivo || Objetivo == null || Math.Abs(Objetivo.XFin - Objetivo.XInicio) < 0.1)
            {
                GenerarObjetivoAleatorio();
            }
            Reiniciar();
        }

        public void GenerarObjetivoAleatorio()
        {
            // El objetivo se coloca estratégicamente dentro del alcance y altura del tiro
            double alcanceEstimado = Math.Max(Teorico.AlcanceHorizontal - X0, 50.0);
            double hMaxEstimada = Math.Max(Teorico.AlturaMaxima, 20.0);

            // Posición X entre el 30% y el 75% del alcance
            double xCentro = X0 + alcanceEstimado * (0.35 + rand.NextDouble() * 0.40);
            double ancho = Math.Max(alcanceEstimado * 0.15, 10.0); // Ancho del 15% del alcance

            // Altura entre el 20% y el 70% de la altura máxima
            double yObj = Math.Max(5.0, hMaxEstimada * (0.25 + rand.NextDouble() * 0.45));

            Objetivo = new ObjetivoHorizontal
            {
                XInicio = Math.Round(xCentro - ancho / 2.0, 2),
                XFin = Math.Round(xCentro + ancho / 2.0, 2),
                Y = Math.Round(yObj, 2)
            };
        }

        public void Reiniciar()
        {
            T = 0.0;
            X = X0;
            Y = Y0;

            double rad = AnguloGrad * (Math.PI / 180.0);
            Vx = V0 * Math.Cos(rad);
            Vy = V0 * Math.Sin(rad);

            huboColisionObjetivo = false;
            conteoRebotesSuelo = 0;
            SimulacionFinalizada = false;

            Trayectoria.Clear();
            Colisiones.Clear();

            PuntoAlturaMax = null;
            EventoColisionObjetivo = null;
            EventoRebote1Suelo = null;
            EventoRebote2Suelo = null;

            maxYSegundoTramo = Y0;
            tiempoMaxYSegundoTramo = 0.0;

            Simulado = new ResultadosSimulados
            {
                AlturaMaxima = Y0,
                TiempoAlturaMaxima = 0.0,
                TiempoVueloPrimerTramo = 0.0,
                AlcancePrimerTramo = 0.0
            };

            // Guardar punto inicial
            RegistrarPuntoTrayectoria();
        }

        public bool AvanzarPaso()
        {
            if (SimulacionFinalizada) return false;

            // Protección anti-bloqueo: Máximo 15,000 pasos de simulación o 300 segundos
            if (Trayectoria.Count > 15000 || T > 300.0)
            {
                SimulacionFinalizada = true;
                return false;
            }

            double xAnt = X;
            double yAnt = Y;
            double vxAnt = Vx;
            double vyAnt = Vy;
            double tAnt = T;

            // Integración numérica (Paso discreto dt)
            double tNuevo = T + Dt;
            double xNuevo = X + Vx * Dt;
            double vyNuevo = Vy - Gravedad * Dt;
            double yNuevo = Y + Vy * Dt - 0.5 * Gravedad * Dt * Dt;

            // Rastreo de altura máxima en simulación
            if (yNuevo > maxYSegundoTramo)
            {
                maxYSegundoTramo = yNuevo;
                tiempoMaxYSegundoTramo = tNuevo;
                Simulado.AlturaMaxima = yNuevo;
                Simulado.TiempoAlturaMaxima = tNuevo;
                PuntoAlturaMax = new PuntoTrayectoria
                {
                    Tiempo = tNuevo,
                    X = xNuevo,
                    Y = yNuevo,
                    Vx = Vx,
                    Vy = vyNuevo,
                    Vmag = Math.Sqrt(Vx * Vx + vyNuevo * vyNuevo),
                    Vang = Math.Atan2(vyNuevo, Vx) * (180.0 / Math.PI)
                };
            }

            // 1. Verificación de colisión con el objetivo horizontal (subida o bajada)
            if (!huboColisionObjetivo && Objetivo != null)
            {
                bool cruzaBajando = (yAnt >= Objetivo.Y && yNuevo <= Objetivo.Y);
                bool cruzaSubiendo = (yAnt <= Objetivo.Y && yNuevo >= Objetivo.Y);

                if ((cruzaBajando || cruzaSubiendo) && Math.Abs(yAnt - yNuevo) > 1e-9)
                {
                    double factor = (yAnt - Objetivo.Y) / (yAnt - yNuevo);
                    factor = Math.Max(0.0, Math.Min(1.0, factor));
                    double xImpacto = xAnt + factor * (xNuevo - xAnt);

                    if (Objetivo.ContieneX(xImpacto))
                    {
                        // ¡COLISIÓN CON EL OBJETIVO!
                        huboColisionObjetivo = true;
                        double tImpacto = tAnt + factor * Dt;
                        double vyImpacto = vyAnt - Gravedad * (factor * Dt);
                        double vxImpacto = vxAnt;

                        double magAntes = Math.Sqrt(vxImpacto * vxImpacto + vyImpacto * vyImpacto);
                        double angAntes = Math.Atan2(vyImpacto, vxImpacto) * (180.0 / Math.PI);

                        // Rebote según la guía:
                        // "la magnitud correspondiente se reduzca en un 40 % (conserva 60%).
                        // La componente vertical deberá cambiar de sentido como consecuencia del rebote."
                        double vxDespues = vxImpacto * 0.60;
                        double vyDespues = (vyImpacto >= 0 ? -1.0 : 1.0) * Math.Abs(vyImpacto) * 0.60;
                        double magDespues = magAntes * 0.60;
                        double angDespues = Math.Atan2(vyDespues, vxDespues) * (180.0 / Math.PI);

                        EventoColisionObjetivo = new ColisionRegistro
                        {
                            Numero = Colisiones.Count + 1,
                            Tipo = "Objetivo Horizontal",
                            Tiempo = Math.Round(tImpacto, 4),
                            X = Math.Round(xImpacto, 3),
                            Y = Math.Round(Objetivo.Y, 3),
                            VxAntes = Math.Round(vxImpacto, 3),
                            VyAntes = Math.Round(vyImpacto, 3),
                            VmagAntes = Math.Round(magAntes, 3),
                            VangAntes = Math.Round(angAntes, 2),
                            VxDespues = Math.Round(vxDespues, 3),
                            VyDespues = Math.Round(vyDespues, 3),
                            VmagDespues = Math.Round(magDespues, 3),
                            VangDespues = Math.Round(angDespues, 2)
                        };
                        Colisiones.Add(EventoColisionObjetivo);

                        // Actualizar estado al punto del rebote
                        T = tImpacto;
                        X = xImpacto;
                        Y = Objetivo.Y;
                        Vx = vxDespues;
                        Vy = vyDespues;

                        RegistrarPuntoTrayectoria();
                        return true;
                    }
                }
            }

            // 2. Verificación de impacto con el suelo (Y <= 0)
            if (yNuevo <= 0.0)
            {
                // Interpolación al suelo
                double factor = yAnt / (yAnt - yNuevo);
                double xImpactoSuelo = xAnt + factor * (xNuevo - xAnt);
                double tImpactoSuelo = tAnt + factor * Dt;
                double vyImpacto = vyAnt - Gravedad * (factor * Dt);
                double vxImpacto = vxAnt;

                double magAntes = Math.Sqrt(vxImpacto * vxImpacto + vyImpacto * vyImpacto);
                double angAntes = Math.Atan2(vyImpacto, vxImpacto) * (180.0 / Math.PI);

                // Si es el primer impacto con el suelo y aún no se registró el primer tramo:
                if (conteoRebotesSuelo == 0 && Simulado.TiempoVueloPrimerTramo == 0.0)
                {
                    Simulado.TiempoVueloPrimerTramo = tImpactoSuelo;
                    Simulado.AlcancePrimerTramo = xImpactoSuelo;
                }

                conteoRebotesSuelo++;

                // Rebote: Reducción del 40% de la magnitud (conserva 60%), Vy cambia de sentido
                double vxDespues = vxImpacto * 0.60;
                double vyDespues = Math.Abs(vyImpacto) * 0.60;
                double magDespues = magAntes * 0.60;
                double angDespues = Math.Atan2(vyDespues, vxDespues) * (180.0 / Math.PI);

                ColisionRegistro colSuelo = new ColisionRegistro
                {
                    Numero = Colisiones.Count + 1,
                    Tipo = $"Rebote Suelo #{conteoRebotesSuelo}",
                    Tiempo = Math.Round(tImpactoSuelo, 4),
                    X = Math.Round(xImpactoSuelo, 3),
                    Y = 0.0,
                    VxAntes = Math.Round(vxImpacto, 3),
                    VyAntes = Math.Round(vyImpacto, 3),
                    VmagAntes = Math.Round(magAntes, 3),
                    VangAntes = Math.Round(angAntes, 2),
                    VxDespues = Math.Round(vxDespues, 3),
                    VyDespues = Math.Round(vyDespues, 3),
                    VmagDespues = Math.Round(magDespues, 3),
                    VangDespues = Math.Round(angDespues, 2)
                };

                Colisiones.Add(colSuelo);

                if (conteoRebotesSuelo == 1)
                {
                    EventoRebote1Suelo = colSuelo;
                }
                else if (conteoRebotesSuelo == 2)
                {
                    EventoRebote2Suelo = colSuelo;
                }

                // El enunciado estipula:
                // "Al colisionar con el suelo deberá realizar un segundo rebote.
                // Después del segundo rebote, el movimiento continuará hasta que el objeto vuelva a alcanzar el suelo,
                // momento en el cual finalizará la simulación."
                if (conteoRebotesSuelo > maxRebotesSueloPermitidos)
                {
                    // Fin de la simulación
                    T = tImpactoSuelo;
                    X = xImpactoSuelo;
                    Y = 0.0;
                    Vx = 0.0;
                    Vy = 0.0;
                    SimulacionFinalizada = true;
                    RegistrarPuntoTrayectoria();
                    return false;
                }

                // Aplicar rebote y continuar
                T = tImpactoSuelo;
                X = xImpactoSuelo;
                Y = 0.0;
                Vx = vxDespues;
                Vy = vyDespues;

                RegistrarPuntoTrayectoria();
                return true;
            }

            // Movimiento normal en el aire
            T = tNuevo;
            X = xNuevo;
            Y = yNuevo;
            Vy = vyNuevo;

            RegistrarPuntoTrayectoria();
            return true;
        }

        private void RegistrarPuntoTrayectoria()
        {
            Trayectoria.Add(new PuntoTrayectoria
            {
                Tiempo = Math.Round(T, 4),
                X = Math.Round(X, 3),
                Y = Math.Max(0.0, Math.Round(Y, 3)),
                Vx = Math.Round(Vx, 3),
                Vy = Math.Round(Vy, 3),
                Vmag = Math.Round(Vmag, 3),
                Vang = Math.Round(Vang, 2)
            });
        }

        public void CalcularModeloTeorico()
        {
            double rad = AnguloGrad * (Math.PI / 180.0);
            double v0x = V0 * Math.Cos(rad);
            double v0y = V0 * Math.Sin(rad);

            // 1. Instante y altura máxima
            double tHmax = (v0y > 0) ? (v0y / Gravedad) : 0.0;
            double hMax = Y0 + (v0y > 0 ? (v0y * v0y) / (2.0 * Gravedad) : 0.0);
            double xHmax = X0 + v0x * tHmax;

            // 2. Tiempo total de vuelo hasta el suelo (Y = 0)
            // Ecuación cuadrática: 0.5*g*t^2 - v0y*t - Y0 = 0
            double discriminante = v0y * v0y + 2.0 * Gravedad * Y0;
            double tVuelo = 0.0;
            if (discriminante >= 0)
            {
                tVuelo = (v0y + Math.Sqrt(discriminante)) / Gravedad;
            }

            // 3. Alcance horizontal
            double alcance = X0 + v0x * tVuelo;

            // 4. Velocidad en el punto de máxima altura
            double velHMax_Vx = v0x;
            double velHMax_Vy = 0.0;
            double velHMax_Mag = Math.Abs(v0x);
            double velHMax_Ang = (v0x >= 0) ? 0.0 : 180.0;

            // 5. Velocidad inmediatamente antes del impacto con el suelo
            double velImp_Vx = v0x;
            double velImp_Vy = v0y - Gravedad * tVuelo;
            double velImp_Mag = Math.Sqrt(velImp_Vx * velImp_Vx + velImp_Vy * velImp_Vy);
            double velImp_Ang = Math.Atan2(velImp_Vy, velImp_Vx) * (180.0 / Math.PI);

            Teorico = new ResultadosTeoricos
            {
                TiempoAlturaMaxima = Math.Round(tHmax, 4),
                AlturaMaxima = Math.Round(hMax, 3),
                PosXAlturaMaxima = Math.Round(xHmax, 3),
                TiempoVuelo = Math.Round(tVuelo, 4),
                AlcanceHorizontal = Math.Round(alcance, 3),

                VelHMax_Vx = Math.Round(velHMax_Vx, 3),
                VelHMax_Vy = Math.Round(velHMax_Vy, 3),
                VelHMax_Mag = Math.Round(velHMax_Mag, 3),
                VelHMax_Ang = Math.Round(velHMax_Ang, 2),

                VelImpacto_Vx = Math.Round(velImp_Vx, 3),
                VelImpacto_Vy = Math.Round(velImp_Vy, 3),
                VelImpacto_Mag = Math.Round(velImp_Mag, 3),
                VelImpacto_Ang = Math.Round(velImp_Ang, 2)
            };
        }

        public bool DeterminarSiTrayectoriaIntersecta(out double xCruce, out double tCruce)
        {
            xCruce = 0.0;
            tCruce = 0.0;
            if (Objetivo == null) return false;

            double rad = AnguloGrad * (Math.PI / 180.0);
            double v0x = V0 * Math.Cos(rad);
            double v0y = V0 * Math.Sin(rad);

            double discriminante = v0y * v0y - 2.0 * Gravedad * (Objetivo.Y - Y0);
            if (discriminante < 0) return false;

            double sqrtDisc = Math.Sqrt(discriminante);
            double t1 = (v0y - sqrtDisc) / Gravedad;
            double t2 = (v0y + sqrtDisc) / Gravedad;

            // Revisar cruce en subida
            if (t1 > 0.001)
            {
                double x1 = X0 + v0x * t1;
                if (Objetivo.ContieneX(x1))
                {
                    xCruce = Math.Round(x1, 2);
                    tCruce = Math.Round(t1, 3);
                    return true;
                }
            }

            // Revisar cruce en bajada
            if (t2 > 0.001)
            {
                double x2 = X0 + v0x * t2;
                if (Objetivo.ContieneX(x2))
                {
                    xCruce = Math.Round(x2, 2);
                    tCruce = Math.Round(t2, 3);
                    return true;
                }
            }

            return false;
        }
    }
}
