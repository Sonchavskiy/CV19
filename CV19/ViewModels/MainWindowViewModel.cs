﻿using CV19.Infrastructure.Commands;
using CV19.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CV19.ViewModels
{
    
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок окна
        private string _Title = "Анализ статистики CV19";

        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion


        #region Status : string - Статус программы

        private string _Status = "Готов!";

        public string Status
        {
            get => _Status;
            set => Set(ref _Status, value);
        }

        #endregion

        #region Команды


        #region CloseApplicationCommand
        public ICommand CloseApplicationCommand { get; }

        private bool CanCloseApplicationCommandExecute(object p) => true;
        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }
        #endregion


        #endregion


        public MainWindowViewModel()
        {
            #region Команды

            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);

            #endregion

        }
    }
}
