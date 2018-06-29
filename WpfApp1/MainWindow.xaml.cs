﻿using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

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
		private int fails;
		private bool isBackspace = false;
		private bool isCapslock = false;
		private bool isOnKeyboard = false;
		private bool isSensitive;
		private bool isShift = false;
		private bool isSpeed = false;
		private int speed;
		char symbolCorrect;

		private void ButtonStart_Click(object sender, RoutedEventArgs e)
		{
			buttonStart.IsEnabled = false;
			buttonStop.IsEnabled = true;
			caseSensitive.IsEnabled = false;
			difficulty.IsEnabled = false;
			isOnKeyboard = true;
			OriginalString();
		}

		private void ButtonStop_Click(object sender, RoutedEventArgs e)
		{
			buttonStart.IsEnabled = true;
			buttonStop.IsEnabled = false;
			caseSensitive.IsEnabled = true;
			difficulty.IsEnabled = true;
			fails = 0;
			isCapslock = false;
			isOnKeyboard = false;
			originalKey.Text = "";
			showFails.Text = fails.ToString();
			showSpeed.Text = speed.ToString();
			speed = 0;
			userKey.Text = "";
		}

		private void CaseSensitive_Checked(object sender, RoutedEventArgs e)
		{
			isSensitive = true;
		}

		private void Difficulty_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			showDifficulty.Text = difficulty.Value.ToString();
		}

		private void OriginalString()
		{
			Random symbolNumber = new Random((int)DateTime.Now.Ticks);
			for (int index = 1; originalKey.Text.Length < 48; index++)
			{
				if (!isSensitive)
				{
					char symbol = (char)symbolNumber.Next(97, 122);
					originalKey.Text += symbol;
					if (index % difficulty.Value == 0)
					{
						originalKey.Text += " ";
						originalKey.Text += symbol;
						++index;
					}
				}
				else
				{
					char symbol = (char)symbolNumber.Next(33, 126);
					originalKey.Text += symbol;
					if (index % difficulty.Value == 0)
					{
						originalKey.Text += " ";
						originalKey.Text += symbol;
						++index;
					}
				}
			}
		}

		private void SpeedFails()
		{
			if (isSpeed)
			{
				speed += 1;
				showSpeed.Text = speed.ToString();
				isSpeed = false;
			}
			else
			{
				fails += 1;
				showFails.Text = fails.ToString();
			}
		}

		private void ShowKeyboard()
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
			if (isOnKeyboard)
			{
				if (userKey.Text.Length == originalKey.Text.Length)
				{
					userKey.Text = "";
				}
				switch (e.Key)
				{
					case Key.OemTilde:
						bTilda.Background = Brushes.DeepPink;
						if (isShift)
						{
							symbolCorrect = '~';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += "~";
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = '`';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += "`";
								isSpeed = true;
							}
						}
						break;
					case Key.D1:
						b1.Background = Brushes.DeepPink;
						if (isShift)
						{
							symbolCorrect = '!';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = '1';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.D2:
						b2.Background = Brushes.DeepPink;
						if (isShift)
						{
							symbolCorrect = '@';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = '2';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.D3:
						b3.Background = Brushes.YellowGreen;
						if (isShift)
						{
							symbolCorrect = '#';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = '3';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.D4:
						b4.Background = Brushes.Green;
						if (isShift)
						{
							symbolCorrect = '$';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = '4';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.D5:
						b5.Background = Brushes.Blue;
						if (isShift)
						{
							symbolCorrect = '%';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = '5';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}

						break;
					case Key.D6:
						b6.Background = Brushes.Blue;
						if (isShift)
						{
							symbolCorrect = '^';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = '6';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.D7:
						b7.Background = Brushes.Purple;
						if (isShift)
						{
							symbolCorrect = '&';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = '7';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.D8:
						b8.Background = Brushes.Purple;
						if (isShift)
						{
							symbolCorrect = '*';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = '8';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.D9:
						b9.Background = Brushes.DeepPink;
						if (isShift)
						{
							symbolCorrect = '(';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = '9';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.D0:
						b0.Background = Brushes.YellowGreen;
						if (isShift)
						{
							symbolCorrect = ')';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = '0';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.OemMinus:
						bMinus.Background = Brushes.Green;
						if (isShift)
						{
							symbolCorrect = '_';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = '-';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.OemPlus:
						bPlus.Background = Brushes.Green;
						if (isShift)
						{
							symbolCorrect = '+';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = '=';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.Back:
						bBackspace.Background = Brushes.Gray;
						isBackspace = true;
						break;
					case Key.Tab:
						bTab.Background = Brushes.Gray;
						break;
					case Key.Q:
						bQ.Background = Brushes.DeepPink;
						if (isCapslock || isShift)
						{
							symbolCorrect = 'Q';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = 'q';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.W:
						bW.Background = Brushes.YellowGreen;
						if (isCapslock || isShift)
						{
							symbolCorrect = 'W';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = 'w';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.E:
						bE.Background = Brushes.Green;
						if (isCapslock || isShift)
						{
							symbolCorrect = 'E';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = 'e';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.R:
						bR.Background = Brushes.Blue;
						if (isCapslock || isShift)
						{
							symbolCorrect = 'R';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = 'r';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.T:
						bT.Background = Brushes.Blue;
						if (isCapslock || isShift)
						{
							symbolCorrect = 'T';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = 't';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.Y:
						bY.Background = Brushes.Purple;
						if (isCapslock || isShift)
						{
							symbolCorrect = 'Y';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = 'y';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.U:
						bU.Background = Brushes.Purple;
						if (isCapslock || isShift)
						{
							symbolCorrect = 'U';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = 'u';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.I:
						bI.Background = Brushes.DeepPink;
						if (isCapslock || isShift)
						{
							symbolCorrect = 'I';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = 'i';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.O:
						bO.Background = Brushes.YellowGreen;
						if (isCapslock || isShift)
						{
							symbolCorrect = 'O';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = 'o';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.P:
						bP.Background = Brushes.Green;
						if (isCapslock || isShift)
						{
							symbolCorrect = 'P';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = 'p';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.OemOpenBrackets:
						bOpenBrackets.Background = Brushes.Green;
						if (isShift)
						{
							symbolCorrect = '{';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = '[';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.OemCloseBrackets:
						bCloseBrackets.Background = Brushes.Green;
						if (isShift)
						{
							symbolCorrect = '}';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = ']';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.OemPipe:
						bPipe.Background = Brushes.Green;
						if (isShift)
						{
							symbolCorrect = '|';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = '\\';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.CapsLock:
						if (!isCapslock)
						{
							bCapsLock.Background = Brushes.Gray;
							isCapslock = true;
							ShowKeyboard();
						}
						else
						{
							bCapsLock.Background = Brushes.LightGray;
							isCapslock = false;
							ShowKeyboard();
						}
						break;
					case Key.A:
						bA.Background = Brushes.DeepPink;
						if (isCapslock || isShift)
						{
							symbolCorrect = 'A';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = 'a';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.S:
						bS.Background = Brushes.YellowGreen;
						if (isCapslock || isShift)
						{
							symbolCorrect = 'S';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = 's';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.D:
						bD.Background = Brushes.Green;
						if (isCapslock || isShift)
						{
							symbolCorrect = 'D';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = 'd';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.F:
						bF.Background = Brushes.Blue;
						if (isCapslock || isShift)
						{
							symbolCorrect = 'F';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = 'f';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.G:
						bG.Background = Brushes.Blue;
						if (isCapslock || isShift)
						{
							symbolCorrect = 'g';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = 'g';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.H:
						bH.Background = Brushes.Purple;
						if (isCapslock || isShift)
						{
							symbolCorrect = 'H';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
							symbolCorrect = 'h';
						if (symbolCorrect == originalKey.Text[userKey.Text.Length])
						{
							userKey.Text += symbolCorrect;
							isSpeed = true;
						}
						break;
					case Key.J:
						bJ.Background = Brushes.Purple;
						if (isCapslock || isShift)
						{
							symbolCorrect = 'J';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = 'j';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.K:
						bK.Background = Brushes.DeepPink;
						if (isCapslock || isShift)
						{
							symbolCorrect = 'K';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = 'k';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.L:
						bL.Background = Brushes.YellowGreen;
						if (isCapslock || isShift)
						{
							symbolCorrect = 'L';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = 'l';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							};
						}
						break;
					case Key.OemSemicolon:
						bSemicolon.Background = Brushes.Green;
						if (isShift)
						{
							symbolCorrect = ':';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = ';';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.OemQuotes:
						bQuotes.Background = Brushes.Green;
						if (isShift)
						{
							symbolCorrect = '\"';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = '\'';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.Enter:
						bEnter.Background = Brushes.Gray;
						break;
					case Key.LeftShift:
						isShift = true;
						ShowKeyboard();
						bLShift.Background = Brushes.Gray;
						break;
					case Key.Z:
						bZ.Background = Brushes.DeepPink;
						if (isCapslock || isShift)
						{
							symbolCorrect = 'Z';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = 'z';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.X:
						bX.Background = Brushes.YellowGreen;
						if (isCapslock || isShift)
						{
							symbolCorrect = 'X';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = 'x';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.C:
						bC.Background = Brushes.Green;
						if (isCapslock || isShift)
						{
							symbolCorrect = 'C';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = 'c';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.V:
						bV.Background = Brushes.Blue;
						if (isCapslock || isShift)
						{
							symbolCorrect = 'V';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = 'v';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.B:
						bB.Background = Brushes.Blue;
						if (isCapslock || isShift)
						{
							symbolCorrect = 'B';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = 'b';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.N:
						bN.Background = Brushes.Purple;
						if (isCapslock || isShift)
						{
							symbolCorrect = 'N';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = 'n';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.M:
						bM.Background = Brushes.Purple;
						if (isCapslock || isShift)
						{
							symbolCorrect = 'M';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = 'm';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.OemComma:
						bComma.Background = Brushes.DeepPink;
						if (isShift)
						{
							symbolCorrect = '<';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = ',';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.OemPeriod:
						bPeriod.Background = Brushes.YellowGreen;
						if (isShift)
						{
							symbolCorrect = '>';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = '.';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.OemQuestion:
						bQuestion.Background = Brushes.Green;
						if (isShift)
						{
							symbolCorrect = '?';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						else
						{
							symbolCorrect = '/';
							if (symbolCorrect == originalKey.Text[userKey.Text.Length])
							{
								userKey.Text += symbolCorrect;
								isSpeed = true;
							}
						}
						break;
					case Key.RightShift:
						isShift = true;
						bRShift.Background = Brushes.Gray;
						ShowKeyboard();
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
						symbolCorrect = ' ';
						if (symbolCorrect == originalKey.Text[userKey.Text.Length])
						{
							userKey.Text += symbolCorrect;
							isSpeed = true;
						}
						break;
					case Key.RightAlt:
						bRalt.Background = Brushes.Gray;
						break;
					case Key.RightCtrl:
						bRCtrl.Background = Brushes.Gray;
						break;
				}
				if (userKey.Text.Length == originalKey.Text.Length)
				{
					originalKey.Text = "";
					OriginalString();
					userKey.Text = "";
				}
				if (!isBackspace)
				{
					SpeedFails();
				}
				isBackspace = false;
			}
			else
			{
				switch (e.Key)
				{
					case Key.CapsLock:
						if (!isCapslock)
						{
							bCapsLock.Background = Brushes.Gray;
							isCapslock = true;
							ShowKeyboard();
						}
						else
						{
							bCapsLock.Background = Brushes.LightGray;
							isCapslock = false;
							ShowKeyboard();
						}
						break;
					case Key.LeftShift:
						isShift = true;
						ShowKeyboard();
						bLShift.Background = Brushes.Gray;
						break;
					case Key.RightShift:
						isShift = true;
						bRShift.Background = Brushes.Gray;
						ShowKeyboard();
						break;
				}
			}
		}

		private void Window_KeyUp(object sender, KeyEventArgs e)
		{
			if (isOnKeyboard)
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
						ShowKeyboard();
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
						ShowKeyboard();
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
			else
			{
				switch (e.Key)
				{
					case Key.LeftShift:
						isShift = false;
						ShowKeyboard();
						bLShift.Background = Brushes.LightGray;
						break;
					case Key.RightShift:
						isShift = false;
						bRShift.Background = Brushes.LightGray;
						ShowKeyboard();
						break;
				}
			}
		}
	}
}