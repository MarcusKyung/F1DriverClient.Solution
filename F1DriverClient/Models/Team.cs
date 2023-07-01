using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace F1DriverClient.Models
{
  public class Team
  {
    public int TeamId { get; set; }
    public string TeamName { get; set; }
    public string TeamNationality { get; set; }
    public string TeamPrincipal { get; set; }
    public string TeamBase { get; set; }
    public int TeamChampionships { get; set; } 

    public static List<Team> GetTeams()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Team> teamList = JsonConvert.DeserializeObject<List<Team>>(jsonResponse.ToString());

      return teamList;
    }
  }
}