PostStatususing System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicFacebookFeatures.Checkers;
using CefSharp.DevTools.SystemInfo;
using CheckersUIWindows;

namespace BasicFacebookFeatures
{
    class CheckersFacade
    {
         private string m_LaunchingPlayerName;
         private Image m_UserImage;
         private ListBox m_FriendsListBox;
         public event Action<String> PostStatus;

         public CheckersFacade(String i_LaunchingPlayerName, Image i_UserImage, ListBox i_FriendsListBox)
         {
              m_LaunchingPlayerName = i_LaunchingPlayerName;
              m_UserImage = i_UserImage;
              m_FriendsListBox = i_FriendsListBox;
         }

          public void LaunchCheckers()
         {
              FormGameSettings gameSettings = new FormGameSettings(m_LaunchingPlayerName, m_FriendsListBox);
              
              gameSettings.ShowDialog();
              if(gameSettings.DialogResult == DialogResult.OK)
              {
                   FormBoard board = new FormBoard(gameSettings, m_UserImage);

                   board.ShowDialog();
                   FormPostResult postResultForm = new FormPostResult(board);

                   postResultForm.ShowDialog();

                   if(postResultForm.DialogResult == DialogResult.Yes)
                   {
                        OnPostStatus();
                   }
              }
         }

         private void OnPostStatus(i_EventArgs e)
         {
             if(PostStatus != null)
             {
                  PostStatus.Invoke(postResultForm.getMessageToPost());
             }
         }
    }
}
