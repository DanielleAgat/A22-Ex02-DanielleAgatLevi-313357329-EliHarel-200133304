using System;
using System.Windows.Forms;
using CheckersLogic;
using BasicFacebookFeatures;
using FacebookWrapper.ObjectModel;

namespace CheckersUIWindows
{
     public partial class FormGameSettings : Form
     {

          public FormGameSettings(String i_UserName, ListBox i_FriendsListBox)
          {
               InitializeComponent();
               ListBoxFriendsCheckersSettings = i_FriendsListBox;
               textBoxPlayer1.Text = i_UserName;
               listBoxFriendsCheckersSettings.Enabled = false;
          }

          public ListBox ListBoxFriendsCheckersSettings
          {
               get
               {
                    return listBoxFriendsCheckersSettings;
               }
               set
               {
                    //Copies only the listBox's items into classes' list box, in order to keep the ListBox's attributes
                    foreach (object obj in value.Items)
                    {
                         listBoxFriendsCheckersSettings.Items.Add(obj);
                    }
               }
          }

          public string Player1Name
          {
               get
               {
                    return textBoxPlayer1.Text;
               }
          }

          public string Player2Name
          {
               get
               {
                    return textBoxPlayer2.Text;
               }
          }

          public GameEngine.eGameMode GameMode
          {
               get
               {
                    GameEngine.eGameMode gameMode;

                    if(checkBoxPlayer2.Checked)
                    {
                         gameMode = GameEngine.eGameMode.MultiPlayer;
                    }
                    else
                    {
                         gameMode = GameEngine.eGameMode.SinglePlayer;
                    }

                    return gameMode;
               }
          }

          public Board.eBoardSize BoardSize
          {
               get
               {
                    Board.eBoardSize boardSize;

                    if(radioButton6x6.Checked)
                    {
                         boardSize = Board.eBoardSize.Small;
                    }
                    else if(radioButton8x8.Checked)
                    {
                         boardSize = Board.eBoardSize.Normal;
                    }
                    else
                    {
                         boardSize = Board.eBoardSize.Big;
                    }

                    return boardSize;
               }
          }

          public User Friend
          {
               get
               {
                    User friend = getListBoxSelectedFriend();

                    return friend;
               }
          }

          private void checkBoxPlayer2_CheckedChanged(object i_Sender, EventArgs i_EventArgs)
          {
               if(i_Sender is CheckBox checkbox && checkbox.Checked)
               {
                    textBoxPlayer2.Enabled = true;
                    textBoxPlayer2.Text = "Some foolish contender";
                    listBoxFriendsCheckersSettings.Enabled = true;
                    if(listBoxFriendsCheckersSettings.Items.Count > 0)
                    {
                         if(listBoxFriendsCheckersSettings.SelectedItem != null)
                         {
                              User selectedFriend = (User)listBoxFriendsCheckersSettings.SelectedItem;

                              textBoxPlayer2.Text = selectedFriend.Name;
                         }
                    }
               }
               else
               {
                    textBoxPlayer2.Enabled = false;
                    textBoxPlayer2.Text = "Checkers Robot";
                    listBoxFriendsCheckersSettings.Enabled = false;
                    listBoxFriendsCheckersSettings.ClearSelected();
               }
          }

          private void buttonDone_Click(object i_Sender, EventArgs i_EventArgs)
          {
               if(textBoxPlayer1.Text.Length < 1)
               {
                    textBoxPlayer1.Text = "Player 1";
               }

               if(textBoxPlayer2.Text.Length < 1)
               {
                    textBoxPlayer2.Text = "Player 2";
               }
          }

          private void listBoxFriendsCheckersSettings_SelectedIndexChanged(object sender, EventArgs e)
          {
               User selectedFriend = getListBoxSelectedFriend();

               if(selectedFriend != null)
               {
                    textBoxPlayer2.Text = selectedFriend.Name;
               }
          }

          private User getListBoxSelectedFriend()
          {
               User selectedFriend = null;

               if(listBoxFriendsCheckersSettings.Items.Count > 0)
               {
                    if(listBoxFriendsCheckersSettings.Enabled)
                    {
                         if(listBoxFriendsCheckersSettings.SelectedItem != null)
                         {
                              selectedFriend = (User)listBoxFriendsCheckersSettings.SelectedItem;
                         }
                    }
               }

               return selectedFriend;
          }
     }
}
