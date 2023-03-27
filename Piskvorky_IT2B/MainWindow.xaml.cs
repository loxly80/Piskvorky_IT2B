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

namespace Piskvorky_IT2B
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      Game game = new Game();
      //MessageBox.Show($"Top:{game.Top}; Right:{game.Right}; Bottom:{game.Bottom}; Left:{game.Left}");
      //game.GameObjects.Add(new GameObject(0,0,GameObject.ValueType.Circle));
      //MessageBox.Show($"Top:{game.Top}; Right:{game.Right}; Bottom:{game.Bottom}; Left:{game.Left}");
      //game.GameObjects.Add(new GameObject(1, 2, GameObject.ValueType.Circle));
      //MessageBox.Show($"Top:{game.Top}; Right:{game.Right}; Bottom:{game.Bottom}; Left:{game.Left}");
      //game.GameObjects.Add(new GameObject(1, -3, GameObject.ValueType.Circle));
      //MessageBox.Show($"Top:{game.Top}; Right:{game.Right}; Bottom:{game.Bottom}; Left:{game.Left}");
      //game.GameObjects.Add(new GameObject(-4, -3, GameObject.ValueType.Circle));
      //MessageBox.Show($"Top:{game.Top}; Right:{game.Right}; Bottom:{game.Bottom}; Left:{game.Left}");
    }

    private Grid CreateGrid(int size, int countX, int countY)
    {
      Grid grid = new Grid();
      grid.Height = size * countY;
      grid.Width = size * countX;
      for (int x = 0; x < countX; x++)
      {
        grid.ColumnDefinitions.Add(new ColumnDefinition());
      }
      for (int y = 0; y < countY; y++)
      {
        grid.RowDefinitions.Add(new RowDefinition());
      }
      this.AddChild(grid);
      return grid;
    }

    private void Window_Initialized(object sender, EventArgs e)
    {
      Grid grid = CreateGrid(50, 6, 6);

      for (int x = 0; x < 6; x++)
      {
        for (int y = 0; y < 6; y++)
        {
          Button button = new Button();
          button.HorizontalAlignment = HorizontalAlignment.Stretch;
          button.VerticalAlignment = VerticalAlignment.Stretch;
          button.Background = new SolidColorBrush(Colors.LightSalmon);
          Grid.SetColumn(button, x);
          Grid.SetRow(button, y);
          grid.Children.Add(button);
        }
      }
    }
  }
}
