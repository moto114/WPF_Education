﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeHelloWorldXaml
{
    using System.Windows;
    using System.Windows.Controls;
    public class MainWindow : Window
    {
        private Button helloWorldButton;

        private void InitializeComponent()
        {
            // Windowのプロパティ設定
            this.Title = "MainWindow";
            this.Height = 350;
            this.Width = 525;

            // Buttonの作成
            this.helloWorldButton = new Button
            {
                Content = "Hello world",
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new Thickness(10, 10, 0, 0),
                Width = 100
            };
            this.helloWorldButton.Click += helloWorldButton_Click;  // クリックイベント


            // Gridの作成
            var grid = new Grid();
            grid.Children.Add(this.helloWorldButton);

            // gridをWindowに設定
            this.Content = grid;
        }

        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void helloWorldButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello world");
        }
    }
}
