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

		private bool isCapslock = false;
		private bool isShift = false;

		private void Button_Click(object sender, RoutedEventArgs e)
		{
		}

		private void Keyboard()
		{
			if (isShift || isCapslock)
			{
				tTilda.Text = "~";
				t1.Text = "!";
				t2.Text = "@";
				t3.Text = "#";
				t4.Text = "$";
				t5.Text = "%";
				t6.Text = "^";
				t7.Text = "&";
				t8.Text = "*";
				t9.Text = "(";
				t0.Text = ")";
				tMinus.Text = "_";
				tPlus.Text = "+";
				tQ.Text = "Q";
				tW.Text = "W";
				tE.Text = "E";
				tR.Text = "R";
				tT.Text = "T";
				tY.Text = "Y";
				tU.Text = "U";
				tI.Text = "I";
				tO.Text = "O";
				tP.Text = "P";
				tOpenBrackets.Text = "{";
				tCloseBrackets.Text = "}";
				tPipe.Text = "|";
				tA.Text = "A";
				tS.Text = "S";
				tD.Text = "D";
				tF.Text = "F";
				tG.Text = "G";
				tH.Text = "H";
				tJ.Text = "J";
				tK.Text = "K";
				tL.Text = "L";
				tSemicolon.Text = ":";
				tQuotes.Text = "\"";
				tZ.Text = "Z";
				tX.Text = "X";
				tC.Text = "C";
				tV.Text = "V";
				tB.Text = "B";
				tN.Text = "N";
				tM.Text = "M";
				tComma.Text = "<";
				tPeriod.Text = ">";
				tQuestion.Text = "?";

			}
			else
			{
				tTilda.Text = "`";
				t1.Text = "1";
				t2.Text = "2";
				t3.Text = "3";
				t4.Text = "4";
				t5.Text = "5";
				t6.Text = "6";
				t7.Text = "7";
				t8.Text = "8";
				t9.Text = "9";
				t0.Text = "0";
				tMinus.Text = "-";
				tPlus.Text = "=";
				tQ.Text = "q";
				tW.Text = "w";
				tE.Text = "e";
				tR.Text = "r";
				tT.Text = "t";
				tY.Text = "y";
				tU.Text = "u";
				tI.Text = "i";
				tO.Text = "o";
				tP.Text = "p";
				tOpenBrackets.Text = "[";
				tCloseBrackets.Text = "]";
				tPipe.Text = "\\";
				tA.Text = "a";
				tS.Text = "s";
				tD.Text = "d";
				tF.Text = "f";
				tG.Text = "g";
				tH.Text = "h";
				tJ.Text = "j";
				tK.Text = "k";
				tL.Text = "l";
				tSemicolon.Text = ";";
				tQuotes.Text = "'";
				tZ.Text = "z";
				tX.Text = "x";
				tC.Text = "c";
				tV.Text = "v";
				tB.Text = "b";
				tN.Text = "n";
				tM.Text = "m";
				tComma.Text = ",";
				tPeriod.Text = ".";
				tQuestion.Text = "/";
			}
		}

		private void Window_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.Key)
			{
				case Key.OemTilde:
					bTilda.Background = Brushes.DeepPink;
					if (isShift)
					{
						userKey.Text += "~";
					}
					else
					{
						userKey.Text += "`";
					}
					break;
				case Key.D1:
					b1.Background = Brushes.DeepPink;
					if (isShift)
					{
						userKey.Text += "!";
					}
					else
					{
						userKey.Text += "1";
					}
					break;
				case Key.D2:
					b2.Background = Brushes.DeepPink;
					if (isShift)
					{
						userKey.Text += "@";
					}
					else
					{
						userKey.Text += "2";
					}

					break;
				case Key.D3:
					b3.Background = Brushes.YellowGreen;
					if (isShift)
					{
						userKey.Text += "#";
					}
					else
					{
						userKey.Text += "3";

					}
					break;
				case Key.D4:
					b4.Background = Brushes.Green;
					if (isShift)
					{
						userKey.Text += "$";
					}
					else
					{
						userKey.Text += "4";
					}
					break;
				case Key.D5:
					b5.Background = Brushes.Blue;
					if (isShift)
					{
						userKey.Text += "%";
					}
					else
					{
						userKey.Text += "5";
					}

					break;
				case Key.D6:
					b6.Background = Brushes.Blue;
					if (isShift)
					{
						userKey.Text += "^";
					}
					else
					{
						userKey.Text += "6";
					}
					break;
				case Key.D7:
					b7.Background = Brushes.Purple;
					if (isShift)
					{
						userKey.Text += "&";
					}
					else
					{
						userKey.Text += "7";
					}
					break;
				case Key.D8:
					b8.Background = Brushes.Purple;
					if (isShift)
					{
						userKey.Text += "*";
					}
					else
					{
						userKey.Text += "8";
					}
					break;
				case Key.D9:
					b9.Background = Brushes.DeepPink;
					if (isShift)
					{
						userKey.Text += "(";
					}
					else
					{
						userKey.Text += "9";
					}
					break;
				case Key.D0:
					b0.Background = Brushes.YellowGreen;
					if (isShift)
					{
						userKey.Text += ")";
					}
					else
					{
						userKey.Text += "0";
					}
					break;
				case Key.OemMinus:
					bMinus.Background = Brushes.Green;
					if (isShift)
					{
						userKey.Text += "_";
					}
					else
					{
						userKey.Text += "-";
					}
					break;
				case Key.OemPlus:
					bPlus.Background = Brushes.Green;
					if (isShift)
					{
						userKey.Text += "+";
					}
					else
					{
						userKey.Text += "=";
					}
					break;
				case Key.Back:
					if (userKey.Text.Length > 0)
					{
						bBackspace.Background = Brushes.Gray;
						userKey.Text = userKey.Text.Remove(userKey.Text.Length - 1, 1);
					}
					break;
				case Key.Tab:
					bTab.Background = Brushes.Gray;
					break;
				case Key.Q:
					bQ.Background = Brushes.DeepPink;
					if (isCapslock || isShift)
					{
						userKey.Text += "Q";
					}
					else
					{
						userKey.Text += "q";
					}
					break;
				case Key.W:
					bW.Background = Brushes.YellowGreen;
					if (isCapslock || isShift)
					{
						userKey.Text += "W";
					}
					else
					{
						userKey.Text += "w";
					}
					break;
				case Key.E:
					bE.Background = Brushes.Green;
					if (isCapslock || isShift)
					{
						userKey.Text += "E";
					}
					else
					{
						userKey.Text += "e";
					}
					break;
				case Key.R:
					bR.Background = Brushes.Blue;
					if (isCapslock || isShift)
					{
						userKey.Text += "R";
					}
					else
					{
						userKey.Text += "r";
					}
					break;
				case Key.T:
					bT.Background = Brushes.Blue;
					if (isCapslock || isShift)
					{
						userKey.Text += "T";
					}
					else
					{
						userKey.Text += "t";
					}
					break;
				case Key.Y:
					bY.Background = Brushes.Purple;
					if (isCapslock || isShift)
					{
						userKey.Text += "Y";
					}
					else
					{
						userKey.Text += "y";
					}
					break;
				case Key.U:
					bU.Background = Brushes.Purple;
					if (isCapslock || isShift)
					{
						userKey.Text += "U";
					}
					else
					{
						userKey.Text += "u";
					}
					break;
				case Key.I:
					bI.Background = Brushes.DeepPink;
					if (isCapslock || isShift)
					{
						userKey.Text += "I";
					}
					else
					{
						userKey.Text += "i";
					}
					break;
				case Key.O:
					bO.Background = Brushes.YellowGreen;
					if (isCapslock || isShift)
					{
						userKey.Text += "O";
					}
					else
					{
						userKey.Text += "0";
					}
					break;
				case Key.P:
					bP.Background = Brushes.Green;
					if (isCapslock || isShift)
					{
						userKey.Text += "P";
					}
					else
					{
						userKey.Text += "p";
					}
					break;
				case Key.OemOpenBrackets:
					bOpenBrackets.Background = Brushes.Green;
					if (isShift)
					{
						userKey.Text += "{";
					}
					else
					{
						userKey.Text += "[";
					}
					break;
				case Key.OemCloseBrackets:
					bCloseBrackets.Background = Brushes.Green;
					if (isShift)
					{
						userKey.Text += "}";
					}
					else
					{
						userKey.Text += "]";
					}
					break;
				case Key.OemPipe:
					bPipe.Background = Brushes.Green;
					if (isShift)
					{
						userKey.Text += "|";
					}
					else
					{
						userKey.Text += "\\";
					}
					break;
				case Key.CapsLock:
					if (!isCapslock)
					{
						bCapsLock.Background = Brushes.Gray;
						isCapslock = true;
						Keyboard();
					}
					else
					{
						bCapsLock.Background = Brushes.LightGray;
						isCapslock = false;
						Keyboard();
					}
					break;
				case Key.A:
					bA.Background = Brushes.DeepPink;
					if (isCapslock || isShift)
					{
						userKey.Text += "A";
					}
					else
					{
						userKey.Text += "a";
					}
					break;
				case Key.S:
					bS.Background = Brushes.YellowGreen;
					if (isCapslock || isShift)
					{
						userKey.Text += "S";
					}
					else
					{
						userKey.Text += "s";
					}
					break;
				case Key.D:
					bD.Background = Brushes.Green;
					if (isCapslock || isShift)
					{
						userKey.Text += "D";
					}
					else
					{
						userKey.Text += "d";
					}
					break;
				case Key.F:
					bF.Background = Brushes.Blue;
					if (isCapslock || isShift)
					{
						userKey.Text += "F";
					}
					else
					{
						userKey.Text += "f";
					}
					break;
				case Key.G:
					bG.Background = Brushes.Blue;
					if (isCapslock || isShift)
					{
						userKey.Text += "G";
					}
					else
					{
						userKey.Text += "g";
					}
					break;
				case Key.H:
					bH.Background = Brushes.Purple;
					if (isCapslock || isShift)
					{
						userKey.Text += "H";
					}
					else
					{
						userKey.Text += "h";
					}
					break;
				case Key.J:
					bJ.Background = Brushes.Purple;
					if (isCapslock || isShift)
					{
						userKey.Text += "J";
					}
					else
					{
						userKey.Text += "j";
					}
					break;
				case Key.K:
					bK.Background = Brushes.DeepPink;
					if (isCapslock || isShift)
					{
						userKey.Text += "K";
					}
					else
					{
						userKey.Text += "k";
					}
					break;
				case Key.L:
					bL.Background = Brushes.YellowGreen;
					if (isCapslock || isShift)
					{
						userKey.Text += "L";
					}
					else
					{
						userKey.Text += "l";
					}
					break;
				case Key.OemSemicolon:
					bSemicolon.Background = Brushes.Green;
					if (isShift)
					{
						userKey.Text += ":";
					}
					else
					{
						userKey.Text += ";";
					}
					break;
				case Key.OemQuotes:
					bQuotes.Background = Brushes.Green;
					if (isShift)
					{
						userKey.Text += "\"";
					}
					else
					{
						userKey.Text += "'";
					}
					break;
				case Key.Enter:
					bEnter.Background = Brushes.Gray;
					break;
				case Key.LeftShift:
					isShift = true;
					bLShift.Background = Brushes.Gray;
					break;
				case Key.Z:
					bZ.Background = Brushes.DeepPink;
					if (isCapslock || isShift)
					{
						userKey.Text += "Z";
					}
					else
					{
						userKey.Text += "z";
					}
					break;
				case Key.X:
					bX.Background = Brushes.YellowGreen;
					if (isCapslock || isShift)
					{
						userKey.Text += "X";
					}
					else
					{
						userKey.Text += "x";
					}
					break;
				case Key.C:
					bC.Background = Brushes.Green;
					if (isCapslock || isShift)
					{
						userKey.Text += "C";
					}
					else
					{
						userKey.Text += "c";
					}
					break;
				case Key.V:
					bV.Background = Brushes.Blue;
					if (isCapslock || isShift)
					{
						userKey.Text += "V";
					}
					else
					{
						userKey.Text += "v";
					}
					break;
				case Key.B:
					bB.Background = Brushes.Blue;
					if (isCapslock || isShift)
					{
						userKey.Text += "B";
					}
					else
					{
						userKey.Text += "b";
					}
					break;
				case Key.N:
					bN.Background = Brushes.Purple;
					if (isCapslock || isShift)
					{
						userKey.Text += "N";
					}
					else
					{
						userKey.Text += "n";
					}
					break;
				case Key.M:
					bM.Background = Brushes.Purple;
					if (isCapslock || isShift)
					{
						userKey.Text += "M";
					}
					else
					{
						userKey.Text += "m";
					}
					break;
				case Key.OemComma:
					bComma.Background = Brushes.DeepPink;
					if (isShift)
					{
						userKey.Text += "<";
					}
					else
					{
						userKey.Text += ",";
					}
					break;
				case Key.OemPeriod:
					bPeriod.Background = Brushes.YellowGreen;
					if (isShift)
					{
						userKey.Text += ">";
					}
					else
					{
						userKey.Text += ".";
					}
					break;
				case Key.OemQuestion:
					bQuestion.Background = Brushes.Green;
					if (isShift)
					{
						userKey.Text += "?";
					}
					else
					{
						userKey.Text += "/";
					}
					break;
				case Key.RightShift:
					isShift = true;
					bRShift.Background = Brushes.Gray;
					Keyboard();
					break;
				case Key.LeftCtrl:
					bLCtrl.Background = Brushes.Gray;
					break;
				case Key.LWin:
					bLWin.Background = Brushes.Gray;
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
					isShift = false;
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
					isShift = false;
					bRShift.Background = Brushes.LightGray;
					Keyboard();
					break;
				case Key.LeftCtrl:
					bLCtrl.Background = Brushes.LightGray;
					break;
				case Key.LWin:
					bLWin.Background = Brushes.LightGray;
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

		private void difficulty_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			showDifficulty.Text = difficulty.Value.ToString();
		}
	}
}