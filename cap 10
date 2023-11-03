

public class EmpleadoPorComision2
{
    protected string primerNombre;
    protected string apellidoPaterno;
    protected string numeroSeguroSocial;
    protected decimal ventasBrutas; 
    protected decimal tarifaComision; 

    
    public EmpleadoPorComision2(string nombre, string apellido, string nss, decimal ventas, decimal tarifa)
    {
        
        primerNombre = nombre;
        apellidoPaterno = apellido;
        numeroSeguroSocial = nss;
        VentasBrutas = ventas; 
        TarifaComision = tarifa; 
    }

    
    public string PrimerNombre
    {
        get { return primerNombre; }
    }

    
    public string ApellidoPaterno
    {
        get { return apellidoPaterno; }
    }

    // Propiedad de solo lectura que obtiene el número de seguro social del empleado por comisión
    public string NumeroSeguroSocial
    {
        get { return numeroSeguroSocial; }
    }

    // Propiedad que obtiene y establece las ventas brutas del empleado por comisión
    public decimal VentasBrutas
    {
        get { return ventasBrutas; }
        set { ventasBrutas = (value < 0) ? 0 : value; }
    }

    // Propiedad que obtiene y establece la tarifa de comisión del empleado por comisión
    public decimal TarifaComision
    {
        get { return tarifaComision; }
        set { tarifaComision = (value > 0 && value < 1) ? value : 0; }
    }

    // Calcula el salario del empleado por comisión
    public decimal Ingresos()
    {
        return tarifaComision * ventasBrutas;
    }
}
