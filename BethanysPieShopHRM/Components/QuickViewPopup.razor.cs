﻿using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Components
{
    public partial class QuickViewPopup
    {
        private Employee? _employee;

        [Parameter]
        public Employee? Employee { get; set; }

        protected override void OnParametersSet()
        {
            _employee = Employee;

        }

        public void Close()
        {
            _employee = null;
        }

    }
}
