﻿using gamevault.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace gamevault.ViewModels
{
    internal class GameViewViewModel : ViewModelBase
    {
        #region PrivateMembers
        private Game? game { get; set; }
        private Progress? currentUserProgress { get; set; }
        private Progress[]? userProgresses { get; set; }
        private Dictionary<string, string> gameStates { get; set; }
        private bool isInstalled { get; set; }
        private bool? isDownloaded { get; set; }
        private bool showMappedTitle { get; set; }
        #endregion
        public Game? Game
        {
            get { return game; }
            set { game = value; OnPropertyChanged(); }
        }
        public Progress? CurrentUserProgress
        {
            get { return currentUserProgress; }
            set { currentUserProgress = value; OnPropertyChanged(); }
        }
        public Progress[]? UserProgresses
        {
            get { return userProgresses; }
            set { userProgresses = value; OnPropertyChanged(); }
        }
        public Dictionary<string, string>? GameStates
        {
            get => gameStates ?? (gameStates = Enum.GetValues(typeof(State))
                .Cast<State>()
                .ToDictionary(state => GetEnumDescription(state), state => state.ToString()));
            set { gameStates = value; OnPropertyChanged(); }
        }

        private static string GetEnumDescription(State value) =>
            (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) is DescriptionAttribute attribute) ? attribute.Description : value.ToString();
        public bool IsInstalled
        {
            get { return isInstalled; }
            set { isInstalled = value; OnPropertyChanged(); }
        }
        public bool? IsDownloaded
        {
            get { return isDownloaded; }
            set { isDownloaded = value; OnPropertyChanged(); }
        }
        public bool ShowMappedTitle
        {
            get { return showMappedTitle; }
            set { showMappedTitle = value; OnPropertyChanged(); }
        }
    }
}
