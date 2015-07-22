/**
 * Copyright 2015 Marc Rufer, d-fens GmbH
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace biz.dfch.CS.Development.Process
{
    public class Calculator
    {
        public static object Add(Int32 summand1, Int32 summand2)
        {
            return summand1 + summand2;
        }

        public static object Subtract(Int32 minuend, Int32 subtrahend)
        {
            return minuend - subtrahend;
        }

        public static object Divide(Int32 dividend, Int32 divisor)
        {
            return dividend/divisor;
        }

        public static object Multiply(Int32 factor1, Int32 factor2)
        {
            return factor1*factor2;
        }
    }
}
