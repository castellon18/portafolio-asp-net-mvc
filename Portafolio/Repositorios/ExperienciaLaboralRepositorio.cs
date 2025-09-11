using Portafolio.Interfaces;
using Portafolio.Models;

namespace Portafolio.Repositorios
{
    public class ExperienciaLaboralRepositorio : IExperienciaLaboralRepositorio
    {
        public IEnumerable<ExperienciaLaboralModel> ObtenerExperienciasLaborales()
        {
            return
            [
                new ExperienciaLaboralModel
                {
                    Empresa = "Electromecánica Especializada.",
                    Posicion = "Técnico en Informática",
                    Fechas = "2023 - Actualmente",
                    Responsabilidades =
                    [
                        "Instalación y configuración de equipos informáticos, software y sistemas operativos.",
                        "Diagnóstico y solución de problemas técnicos relacionados con hardware, software, redes y sistemas informáticos.",
                        "Brindar asistencia técnica a usuarios para resolver problemas y responder preguntas sobre el uso de la tecnología.",
                        "Configurar y administrar redes informáticas, asegurando su correcto funcionamiento y seguridad.",
                        "Mantener los sistemas y equipos actualizados con las últimas versiones de software y parches de seguridad.",
                        "Administración sistema SIEE (Sistema Integrado Electromecanica Especializada).",
                        "Administrador de sistema NominaEE (Sistema de Nómina de Electromecánica Especializada)."
                    ],
                    Localidad = "Managua, Nicaragua",
                    Tecnologias = [
                        new TecnologiaUsada { Nombre = "Nodejs", Version = "10.6.0" },
                        new TecnologiaUsada { Nombre = "Express", Version = "4.17.1" },
                        new TecnologiaUsada { Nombre = "JavaScript", Version = "ES6" },
                        new TecnologiaUsada { Nombre = "TypeScript", Version = "4.5.2" },
                        new TecnologiaUsada { Nombre = "HTML", Version = "5" },
                        new TecnologiaUsada { Nombre = "CSS", Version = "3" },
                        new TecnologiaUsada { Nombre = "Angular", Version = "12.0.0" },
                        new TecnologiaUsada { Nombre = "PrimeNG", Version = "12.0.0" },
                        new TecnologiaUsada { Nombre = "ChartJs", Version = "2.9.3" },
                        new TecnologiaUsada { Nombre = "PostgreSQL", Version = "13.3" },
                        new TecnologiaUsada { Nombre = "SQL Server", Version = "2012" },
                    ]
                },
                new ExperienciaLaboralModel
                {
                    Empresa = "RC Solution IT.",
                    Posicion = "Soporte Técnico -  Empresa DHL Global Forwarding.",
                    Fechas = "2021 - 2023",
                    Responsabilidades =
                    [
                        "Instalación y configuración de equipos informáticos, software y sistemas operativos.",
                        "Diagnóstico y solución de problemas técnicos relacionados con hardware, software, redes y sistemas informáticos.",
                        "Brindar asistencia técnica a usuarios para resolver problemas y responder preguntas sobre el uso de la tecnología.",
                        "Ejecución del Proyecto Control de Asistencia.",
                        "Inducción al manejo de Microsoft Office 365 como atención a usuario.",
                    ],
                    Localidad = "Managua, Nicaragua",
                    Tecnologias = [
                        new TecnologiaUsada { Nombre = "Microsoft Office 365", Version = "2021" },
                        new TecnologiaUsada { Nombre = "Microsoft Teams", Version = "2021" },
                        new TecnologiaUsada { Nombre = "Microsoft SharePoint", Version = "2021" },
                        new TecnologiaUsada { Nombre = "Microsoft OneDrive", Version = "2021" },
                        new TecnologiaUsada { Nombre = "Microsoft Power Automate", Version = "2021" },
                        new TecnologiaUsada { Nombre = "Microsoft Power Apps", Version = "2021" },
                    ]
                },
                new ExperienciaLaboralModel
                {
                    Empresa = "Universidad de Managua (UDM).",
                    Posicion = "Profesor de Horario.",
                    Fechas = "2020",
                    Responsabilidades =
                    [
                        "Informática Aplicada (Excel Básico).",
                        "Programación en C#.",
                        "Diagrama de Flujo.",
                    ],
                    Localidad = "Managua, Nicaragua",
                    Tecnologias = [
                        new TecnologiaUsada { Nombre = "Microsoft Excel", Version = "2019" },
                        new TecnologiaUsada { Nombre = "DPL", Version = "1.0" },
                        new TecnologiaUsada { Nombre = "Microsoft Visual Studio Cromunity", Version = "2019" },
                    ]
                },
                new ExperienciaLaboralModel
                {
                    Empresa = "Repuestos Estrada, S.A.",
                    Posicion = "Encargado de Inventario y Computo.",
                    Fechas = "2016 - 2020",
                    Responsabilidades =
                    [
                        "Manejo de los Sistema ERP CyS (Controles y Sistemas), Velneo.",
                        "Ingreso de las Compras Locales y Extranjeras de mercadería.",
                        "Ingreso de las Salidas de Bodegas por Faltantes en Inventario o por Cambio de Producto al Cliente.",
                        "Ingreso de Entradas a Bodega por Sobrantes en Inventario o por Cambio de Producto al Cliente.",
                        "Ingreso de Precios de Venta.",
                        "Inventario Físico de la Mercadería.",
                        "Prorrateo de las Pólizas de Importación.",
                        "Reporte de Consolidado de Venta para Pedido de Mercadería a los Proveedores.",
                        "Reporte de Ventas Mensuales.",
                        "Reportes de Existencias Mensual de las Diferentes Bodegas.",
                        "Conciliación de los Prestamos entre Tiendas de los Diferentes Productos.",
                        "Ingreso de Traslados entre Tiendas.",
                        "Ingreso de Productos Utilizados para Inversión de Vehículo Pesado.",
                        "Ingreso de los Vehículos Usados para la Venta.",
                        "Conciliación de Facturas del Proveedor contra Mercadería Física Recibida en Bodega.",
                        "Conciliaciones bancarias.",
                        "Ingresos de depósitos bancarios.",
                        "Instalación y configuración de equipos informáticos, software y sistemas operativos.",
                        "Diagnóstico y solución de problemas técnicos relacionados con hardware, software, redes y sistemas informáticos.",
                        "Brindar asistencia técnica a usuarios para resolver problemas y responder preguntas sobre el uso de la tecnología.",
                        "Configurar y administrar redes informáticas, asegurando su correcto funcionamiento y seguridad.",
                        "Mantener los sistemas y equipos actualizados con las últimas versiones de software y parches de seguridad.",
                    ],
                    Localidad = "Managua, Nicaragua",
                    Tecnologias = [
                        new TecnologiaUsada { Nombre = "Microsoft Excel", Version = "2016" },
                    ]
                },
                new ExperienciaLaboralModel
                {
                    Empresa = "Agencia Aduanera Castellanos de Nicaragua, S.A.",
                    Posicion = "Auxiliar Operativo II.",
                    Fechas = "2016",
                    Responsabilidades =
                    [
                        "Manejo del sistema SEA.",
                        "Contabilización de Comprobantes de Pago o CK.",
                        "Contabilización de Transferencias Bancarias.",
                        "Contabilización de Boletines de Impuestos Aduaneros.",
                        "Contabilización de Caja Chica.",
                        "Contabilización de Recibos Oficiales de Caja.",
                        "Gestión de Cuentas por Cobrar a Clientes.",
                        "Conciliación Bancaria.",
                        "Conciliación de las Cuentas Contables de retención 1% y 2%.",
                        "Archivo de los Documentos Contables.",
                    ],
                    Localidad = "Managua, Nicaragua",
                    Tecnologias = [
                        new TecnologiaUsada { Nombre = "Microsoft Excel", Version = "2016" },
                    ]
                },
                 new ExperienciaLaboralModel
                {
                    Empresa = "Humberto Álvarez Sucesores de Nicaragua, S.A.",
                    Posicion = "Auxiliar Contable.",
                    Fechas = "2013 - 2015",
                    Responsabilidades =
                    [
                        "Manejo del sistema TCO.",
                        "Contabilización Transferencias de Pago.",
                        "Contabilización Traslados de fondos de cuentas bancarias.",
                        "Contabilización Caja Chica.",
                        "Contabilización de Pago a Proveedores.",
                        "Contabilización Boletines de Impuestos Aduaneros.",
                        "Contabilización Comprobantes de Diario.",
                        "Reportes y Declaración de IVA e IR por Pagar.",
                        "Elaboración de Colillas de Pago.",
                        "Arqueo de Caja Chica.",
                        "Inventario de Activos Fijos.",
                        "Conciliación Bancaria.",
                        "Archivo de los Documentos Contables.",
                    ],
                    Localidad = "Managua, Nicaragua",
                    Tecnologias = [
                        new TecnologiaUsada { Nombre = "Microsoft Excel", Version = "2016" },
                    ]
                },
            ];
        }
    }
}
