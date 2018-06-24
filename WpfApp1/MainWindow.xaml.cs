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

namespace WpfApp1
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
		}

		private void Window_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.Key)
			{
				case Key.OemTilde:
					bTilda.Background = Brushes.DeepPink;
					break;
				case Key.D1:
					b1.Background = Brushes.DeepPink;
					break;
				case Key.D2:
					b2.Background = Brushes.DeepPink;
					break;
				case Key.D3:
					b3.Background = Brushes.YellowGreen;
					break;
				case Key.D4:
					b4.Background = Brushes.Green;
					break;
				case Key.D5:
					b5.Background = Brushes.Blue;
					break;
				case Key.D6:
					b6.Background = Brushes.Blue;
					break;
				case Key.D7:
					b7.Background = Brushes.Purple;
					break;
				case Key.D8:
					b8.Background = Brushes.Purple;
					break;
				case Key.D9:
					b9.Background = Brushes.DeepPink;
					break;
				case Key.D0:
					b0.Background = Brushes.YellowGreen;
					break;
				case Key.OemMinus:
					bMinus.Background = Brushes.Green;
					break;
				case Key.OemPlus:
					bPlus.Background = Brushes.Green;
					break;
				case Key.Back:
					bBackspace.Background = Brushes.Gray;
					break;
				case Key.Tab:
					bTab.Background = Brushes.Gray;
					break;
				case Key.Q:
					bQ.Background = Brushes.DeepPink;
					break;
				case Key.W:
					bW.Background = Brushes.YellowGreen;
					break;
				case Key.E:
					bE.Background = Brushes.Green;
					break;
				case Key.R:
					bR.Background = Brushes.Blue;
					break;
				case Key.T:
					bT.Background = Brushes.Blue;
					break;
				case Key.Y:
					bY.Background = Brushes.Purple;
					break;
				case Key.U:
					bU.Background = Brushes.Purple;
					break;
				case Key.I:
					bI.Background = Brushes.DeepPink;
					break;
				case Key.O:
					bO.Background = Brushes.YellowGreen;
					break;
				case Key.P:
					bP.Background = Brushes.Green;
					break;
				case Key.OemOpenBrackets:
					bOpenBrackets.Background = Brushes.Green;
					break;
				case Key.OemCloseBrackets:
					bCloseBrackets.Background = Brushes.Green;
					break;
				case Key.OemPipe:
					bPipe.Background = Brushes.Green;
					break;
				case Key.CapsLock:
					bCapsLock.Background = Brushes.Gray;
					break;
				case Key.A:
					bA.Background = Brushes.DeepPink;
					break;
				case Key.S:
					bS.Background = Brushes.YellowGreen;
					break;
				case Key.D:
					bD.Background = Brushes.Green;
					break;
				case Key.F:
					bF.Background = Brushes.Blue;
					break;
				case Key.G:
					bG.Background = Brushes.Blue;
					break;
				case Key.H:
					bH.Background = Brushes.Purple;
					break;
				case Key.J:
					bJ.Background = Brushes.Purple;
					break;
				case Key.K:
					bK.Background = Brushes.DeepPink;
					break;
				case Key.L:
					bL.Background = Brushes.YellowGreen;
					break;
				case Key.OemSemicolon:
					bSemicolon.Background = Brushes.Green;
					break;
				case Key.OemQuotes:
					bQuotes.Background = Brushes.Green;
					break;
				case Key.Enter:
					bEnter.Background = Brushes.Gray;
					break;
				case Key.LeftShift:
					bLShift.Background = Brushes.Gray;
					break;
				case Key.Z:
					bZ.Background = Brushes.DeepPink;
					break;
				case Key.X:
					bX.Background = Brushes.YellowGreen;
					break;
				case Key.C:
					bC.Background = Brushes.Green;
					break;
				case Key.V:
					bV.Background = Brushes.Blue;
					break;
				case Key.B:
					bB.Background = Brushes.Blue;
					break;
				case Key.N:
					bN.Background = Brushes.Purple;
					break;
				case Key.M:
					bM.Background = Brushes.Purple;
					break;
				case Key.OemComma:
					bComma.Background = Brushes.DeepPink;
					break;
				case Key.OemPeriod:
					bPeriod.Background = Brushes.YellowGreen;
					break;
				case Key.OemQuestion:
					bQuestion.Background = Brushes.Green;
					break;
				case Key.RightShift:
					bRShift.Background = Brushes.Gray;
					break;
				case Key.LeftCtrl:
					bLCtrl.Background = Brushes.Gray;
					break;
				case Key.LeftAlt:
					bLAlt.Background = Brushes.Gray;
					break;
				case Key.Space:
					bSpace.Background = Brushes.Brown;
					break;
				case Key.RightAlt:
					bRalt.Background = Brushes.Gray;
					break;
				case Key.RightCtrl:
					bRCtrl.Background = Brushes.Gray;
					break;
			}
		}

		private void Window_KeyUp(object sender, KeyEventArgs e)
		{
			switch (e.Key)
			{
				case Key.OemTilde:
					bTilda.Background = Brushes.Pink;
					break;
				case Key.D1:
					b1.Background = Brushes.Pink;
					break;
				case Key.D2:
					b2.Background = Brushes.Pink;
					break;
				case Key.D3:
					b3.Background = Brushes.Yellow;
					break;
				case Key.D4:
					b4.Background = Brushes.GreenYellow;
					break;
				case Key.D5:
					b5.Background = Brushes.DeepSkyBlue;
					break;
				case Key.D6:
					b6.Background = Brushes.DeepSkyBlue;
					break;
				case Key.D7:
					b7.Background = Brushes.MediumPurple;
					break;
				case Key.D8:
					b8.Background = Brushes.MediumPurple;
					break;
				case Key.D9:
					b9.Background = Brushes.Pink;
					break;
				case Key.D0:
					b0.Background = Brushes.Yellow;
					break;
				case Key.OemMinus:
					bMinus.Background = Brushes.GreenYellow;
					break;
				case Key.OemPlus:
					bPlus.Background = Brushes.GreenYellow;
					break;
				case Key.Back:
					bBackspace.Background = Brushes.LightGray;
					break;
				case Key.Tab:
					bTab.Background = Brushes.LightGray;
					break;
				case Key.Q:
					bQ.Background = Brushes.Pink;
					break;
				case Key.W:
					bW.Background = Brushes.Yellow;
					break;
				case Key.E:
					bE.Background = Brushes.GreenYellow;
					break;
				case Key.R:
					bR.Background = Brushes.DeepSkyBlue;
					break;
				case Key.T:
					bT.Background = Brushes.DeepSkyBlue;
					break;
				case Key.Y:
					bY.Background = Brushes.MediumPurple;
					break;
				case Key.U:
					bU.Background = Brushes.MediumPurple;
					break;
				case Key.I:
					bI.Background = Brushes.Pink;
					break;
				case Key.O:
					bO.Background = Brushes.Yellow;
					break;
				case Key.P:
					bP.Background = Brushes.GreenYellow;
					break;
				case Key.OemOpenBrackets:
					bOpenBrackets.Background = Brushes.GreenYellow;
					break;
				case Key.OemCloseBrackets:
					bCloseBrackets.Background = Brushes.GreenYellow;
					break;
				case Key.OemPipe:
					bPipe.Background = Brushes.GreenYellow;
					break;
				case Key.CapsLock:
					bCapsLock.Background = Brushes.LightGray;
					break;
				case Key.A:
					bA.Background = Brushes.Pink;
					break;
				case Key.S:
					bS.Background = Brushes.Yellow;
					break;
				case Key.D:
					bD.Background = Brushes.GreenYellow;
					break;
				case Key.F:
					bF.Background = Brushes.DeepSkyBlue;
					break;
				case Key.G:
					bG.Background = Brushes.DeepSkyBlue;
					break;
				case Key.H:
					bH.Background = Brushes.MediumPurple;
					break;
				case Key.J:
					bJ.Background = Brushes.MediumPurple;
					break;
				case Key.K:
					bK.Background = Brushes.Pink;
					break;
				case Key.L:
					bL.Background = Brushes.Yellow;
					break;
				case Key.OemSemicolon:
					bSemicolon.Background = Brushes.GreenYellow;
					break;
				case Key.OemQuotes:
					bQuotes.Background = Brushes.GreenYellow;
					break;
				case Key.Enter:
					bEnter.Background = Brushes.LightGray;
					break;
				case Key.LeftShift:
					bLShift.Background = Brushes.LightGray;
					break;
				case Key.Z:
					bZ.Background = Brushes.Pink;
					break;
				case Key.X:
					bX.Background = Brushes.Yellow;
					break;
				case Key.C:
					bC.Background = Brushes.GreenYellow;
					break;
				case Key.V:
					bV.Background = Brushes.DeepSkyBlue;
					break;
				case Key.B:
					bB.Background = Brushes.DeepSkyBlue;
					break;
				case Key.N:
					bN.Background = Brushes.MediumPurple;
					break;
				case Key.M:
					bM.Background = Brushes.MediumPurple;
					break;
				case Key.OemComma:
					bComma.Background = Brushes.Pink;
					break;
				case Key.OemPeriod:
					bPeriod.Background = Brushes.Yellow;
					break;
				case Key.OemQuestion:
					bQuestion.Background = Brushes.GreenYellow;
					break;
				case Key.RightShift:
					bRShift.Background = Brushes.LightGray;
					break;
				case Key.LeftCtrl:
					bLCtrl.Background = Brushes.LightGray;
					break;
				case Key.LeftAlt:
					bLAlt.Background = Brushes.LightGray;
					break;
				case Key.Space:
					bSpace.Background = Brushes.BurlyWood;
					break;
				case Key.RightAlt:
					bRalt.Background = Brushes.LightGray;
					break;
				case Key.RightCtrl:
					bRCtrl.Background = Brushes.LightGray;
					break;
			}
		}
	}
}