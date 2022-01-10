﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superheroes
{
    class MainWindowVM: ObservableObject
    {


        private Superheroe _superheroeActual;

        public Superheroe SuperheroeActual
        {
            get { return _superheroeActual; }
            set {
                if (this._superheroeActual != value)
                {
                    SetProperty(ref _superheroeActual, value);
                }
            }
        }

        private string _contadorActual;

        public string ContadorActual
        {
            get { return _contadorActual; }
            set 
            {
                if (this._contadorActual != value)
                {

                    SetProperty(ref _contadorActual, value);
                }
            }
        }



        private int contador = 0;
        private readonly List<Superheroe> listaHeroes;


        public MainWindowVM()
        {
            listaHeroes = Superheroe.GetSamples();
            SuperheroeActual = listaHeroes[0];
            ContadorActual = "1/3";
        }

        public void Avanza()
        {
            if (contador < 2)
            {
                contador++;
                SuperheroeActual = listaHeroes[contador];
                ContadorActual = (contador + 1).ToString() + "/3";
            }
        }

        public void Retrocede()
        {
            if (contador > 0)
            {
                contador--;
                SuperheroeActual = listaHeroes[contador];
                ContadorActual = (contador + 1).ToString() + "/3";
            }
        }
    }
}
