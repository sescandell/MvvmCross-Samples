﻿using System;
using MvvmCross.Core.ViewModels;
using StarWarsSample.Core.Resources;

namespace StarWarsSample.Core.ViewModels
{
    public abstract class BaseViewModel : MvxViewModel
    {
        protected BaseViewModel()
        {
        }

        /// <summary>
        /// Gets the internationalized string at the given <paramref name="index"/>, which is the key of the resource.
        /// </summary>
        /// <param name="index">Index key of the string from the resources of internationalized strings.</param>
        public string this[string index] => Strings.ResourceManager.GetString(index);
    }

    public abstract class BaseViewModel<TParameter, TResult> : MvxViewModel<TParameter, TResult>
        where TParameter : class
        where TResult : class
    {
        protected BaseViewModel()
        {
        }

        public override void Prepare(TParameter parameter)
        {
            // Override it if you want :)
        }

        /// <summary>
        /// Gets the internationalized string at the given <paramref name="index"/>, which is the key of the resource.
        /// </summary>
        /// <param name="index">Index key of the string from the resources of internationalized strings.</param>
        public string this[string index] => Strings.ResourceManager.GetString(index);
    }
}
