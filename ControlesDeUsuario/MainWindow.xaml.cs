using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ControlesDeUsuario
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboxTitulo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdParametrosFigura.Children.Clear();

            switch(cbFigura.SelectedIndex)
            {
                case 0: //Circulo
                    grdParametrosFigura.Children.Add(new ParametrosCirculo());
                    break;
                case 1: //Triangulo
                    grdParametrosFigura.Children.Add(new ParametroTriangulo());
                    break;
                case 2: //Rectangulo
                    grdParametrosFigura.Children.Add(new ParametroRectangulo());
                    break;
                case 3: //Pentagono
                    grdParametrosFigura.Children.Add(new ParametroPentagono());
                    break;
                case 4: //Cuadrado
                    grdParametrosFigura.Children.Add(new ParametroCuadrado());
                    break;
                case 5: //Trapecio
                    grdParametrosFigura.Children.Add(new ParametroTrapecio());
                    break;

                default:
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double area = 0.0;

            switch(cbFigura.SelectedIndex)
            {
                case 0: //Circulo
                    double radio=double.Parse(((ParametrosCirculo)(grdParametrosFigura.Children[0])).txtRadio.Text);
                   area = Math.PI * radio * radio;
                   break;

                case 1: //Triangulo
                    double basetrian = double.Parse(((ParametroTriangulo)(grdParametrosFigura.Children[0])).tbBaseTrian.Text);
                    double alturatrian = double.Parse(((ParametroTriangulo)(grdParametrosFigura.Children[0])).tbAlturaTrian.Text);
                    area = (basetrian * alturatrian)/2;
                    break;

                case 2: //Rectangulo
                    double baserec = double.Parse(((ParametroRectangulo)(grdParametrosFigura.Children[0])).tbBaseRec.Text);
                    double alturarec = double.Parse(((ParametroRectangulo)(grdParametrosFigura.Children[0])).tbAlturaRec.Text);
                    area = baserec * alturarec;
                    break;

                case 3: //Circulo
                    double perpen = double.Parse(((ParametroPentagono)(grdParametrosFigura.Children[0])).tbPerimetroPen.Text);
                    double apotema = double.Parse(((ParametroPentagono)(grdParametrosFigura.Children[0])).tbApotemaPen.Text);
                    area = (perpen * apotema)/2;
                    break;

                case 4: //Cuadrado
                    double lado1 = double.Parse(((ParametroCuadrado)(grdParametrosFigura.Children[0])).tbL1Cua.Text);
                    double lado2 = double.Parse(((ParametroCuadrado)(grdParametrosFigura.Children[0])).tbL2Cua.Text);
                    area = lado1 * lado2;
                    break;

                case 5: //Trapecio
                    double basemayortra = double.Parse(((ParametroTrapecio)(grdParametrosFigura.Children[0])).tbBaseMayor.Text);
                    double basemenortra = double.Parse(((ParametroTrapecio)(grdParametrosFigura.Children[0])).tbBaseMenor.Text);
                    double alturatra = double.Parse(((ParametroTrapecio)(grdParametrosFigura.Children[0])).tbAlturaTra.Text);
                    area = ((basemayortra + basemenortra)/2)*alturatra;
                    break;

                default:
                    break;
            }
            lblResultado.Text = area.ToString();
        }
    }
}
