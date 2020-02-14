﻿//
// Copyright (c) 2020 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

namespace nanoFramework.Hardware.Drivers
{
    public class KeyPressedEventArgs
    {
        private readonly sbyte _column;
        private readonly sbyte _row;

        /// <summary>
        /// Column index of the pressed key.
        /// </summary>
        public sbyte Column => _column;

        /// <summary>
        /// Row index of the pressed key.
        /// </summary>
        public sbyte Row => _row;

        public KeyPressedEventArgs(sbyte column, sbyte row)
        {
            _column = column;
            _row = row;
        }
    }
}