namespace Contabilidad.asiento
{
    public class AsientoContable
    {
        public Cuenta ctaDebe { get; set; }
        public double montoDebe { get; set; }
        public Cuenta ctaHaber { get; set; }
        public double montoHaber { get; set; }
    }
}