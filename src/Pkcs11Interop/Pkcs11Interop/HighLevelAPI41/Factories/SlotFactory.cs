﻿/*
 *  Copyright 2012-2017 The Pkcs11Interop Project
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */

/*
 *  Written for the Pkcs11Interop project by:
 *  Jaroslav IMRICH <jimrich@jimrich.sk>
 */

using System;
using Net.Pkcs11Interop.Common;
using Net.Pkcs11Interop.HighLevelAPI;
using Net.Pkcs11Interop.HighLevelAPI.Factories;

namespace Net.Pkcs11Interop.HighLevelAPI41.Factories
{
    /// <summary>
    /// Factory for creation of ISlot instances
    /// </summary>
    public class SlotFactory : ISlotFactory
    {
        /// <summary>
        /// Creates slot with specified handle
        /// </summary>
        /// <param name="factories">Factories used by Pkcs11Interop library</param>
        /// <param name="pkcs11">Low level PKCS#11 wrapper</param>
        /// <param name="slotId">PKCS#11 handle of slot</param>
        public ISlot CreateSlot(Pkcs11Factories factories, LowLevelPkcs11 pkcs11, ulong slotId)
        {
            LowLevelAPI41.Pkcs11 p11 = pkcs11 as LowLevelAPI41.Pkcs11;
            if (p11 == null)
                throw new ArgumentException("Incorrect type of low level PKCS#11 wrapper");

            return new Slot(factories, p11, slotId);
        }
    }
}