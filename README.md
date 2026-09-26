# Password generator

## Overview
Simple C# console app that generates a weak password and a stronger password.

## What I learned

I learned that to change string characters on their indexes they first need to be converted to the StringBuilder class
``
private static string createAWeakPassword()
        {
            StringBuilder sb;
            string passwordString = "";
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                passwordString += (char)rnd.Next('a', 'a' + 26);
            }
            sb = new StringBuilder(passwordString);
            int addARandomCharacter = rnd.Next(0, 2);
            if (addARandomCharacter == 1)
            {
                // inserts an underscore at a random position of the string
                sb[rnd.Next(0, sb.Length)] = (char)rnd.Next(95, 95);
            }
            else
            {
               
            }
            passwordString = sb.ToString();
            return passwordString;
        }

``
