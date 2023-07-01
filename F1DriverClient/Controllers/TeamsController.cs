using Microsoft.AspNetCore.Mvc;
using F1DriverClient.Models;

namespace F1DriverClient.Controllers;

public class TeamsController : Controller
{
  public IActionResult Index()
  {
    List<Team> teams = Team.GetTeams();
    return View(teams);
  }

  public IActionResult Details(int id)
  {
    Team team = Team.GetDetails(id);
    return View(team);
  }
}
