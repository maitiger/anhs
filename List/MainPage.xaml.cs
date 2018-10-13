using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using DataAccessLibrary;
using System.Collections.ObjectModel;
using List.Entity;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace List
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<Song> songAnime;

        internal ObservableCollection<Song> SongAnime1 { get => this.songAnime; set => this.songAnime = value; }

        public MainPage()
        {
            this.InitializeComponent();
            this.SongAnime1 = new ObservableCollection<Song>();
            this.SongAnime1.Add(new Song()
            {
                songname = "Rennai Circulation",
                songthumnail = "https://pbs.twimg.com/media/DWX0-TXXcAEzuVT.jpg",
                singer = " Hanazawa Kanna",
                songt = " Hanazawa Kanna "
            });
            this.SongAnime1.Add(new Song()
            {
                songname = "Sakura",
                songthumnail = "https://pbs.twimg.com/media/DWX0-TXXcAEzuVT.jpg",
                singer = " Hanazawa Kanna",
                songt = " Hanazawa Kanna "
            });
            this.SongAnime1.Add(new Song()
            {
                songname = "Nandemonaiya",
                songthumnail = "https://pbs.twimg.com/media/DWX0-TXXcAEzuVT.jpg",
                singer = " Hanazawa Kanna",
                songt = " Hanazawa Kanna "
            });
        }
        private void ADD(object sender, RoutedEventArgs e)
        {
            Song song = new Song()
            {
                songname = this.Name.Text,
                songthumnail = this.Thumnail.Text,
                singer = this.Singer.Text,
                songt = this.Songt.Text

            };
            this.SongAnime1.Add(song);
            this.Name.Text = string.Empty;
            this.Thumnail.Text = string.Empty;
            this.Singer.Text = string.Empty;
            this.Songt.Text = string.Empty;
            MusicModel.AddData(song);

        }
    }
}
