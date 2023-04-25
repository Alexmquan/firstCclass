using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace firstCclass.Models;

public class Chore
{
  public Chore(int id, string name, string roomName, int timesAWeek, bool isHard)
  {
    Id = id;
    Name = name;
    RoomName = roomName;
    TimesAWeek = timesAWeek;
    IsHard = isHard;
  }

  public int Id { get; set; }
  public string Name { get; set; }
  public string RoomName { get; set; }
  public int TimesAWeek { get; set; }
  public bool IsHard { get; set; }

}