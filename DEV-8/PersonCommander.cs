﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV8
{
  /// <summary>
  /// Class for choice necessary command.
  /// </summary>
  public class PersonCommander
  {
    private const string AVERAGE_AGE = "1";
    private const string OLDEST_USER = "2";
    private const string POPULAR_WOMAN_NAMES = "3";

    public static readonly string[] Commands = { AVERAGE_AGE, OLDEST_USER, POPULAR_WOMAN_NAMES};

    private readonly Dictionary<string, Command> CommandsDictionary =
      new Dictionary<string, Command>()
      {
        {AVERAGE_AGE, new AverageAgeCommand()},
        {OLDEST_USER, new OldestUserCommand()},
        {POPULAR_WOMAN_NAMES, new PopularWomanNamesCommand()}
      };

    public void Run(List<Person> persons)
    {
      bool run = true;
      Console.WriteLine("Enter command 1,2 or 3: ");
      while (run)
      {
        string input = Console.ReadLine();
        string command = input;
        foreach (var com in Commands)
        {
          if (input.StartsWith(com))
          {
            command = com;
            break;
          }
        }
        string args = input.Substring(command.Length).TrimStart(null);

        if (Commands.Contains(command))
        {
          CommandsDictionary[command].execute(persons, args);
        }
        else
        {
          Console.WriteLine("Not found such command.");
        }
      }
    }
  }
}
