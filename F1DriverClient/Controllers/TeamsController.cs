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

  public ActionResult Create()
  {
    return View();
  }

  [HttpPost]
  public ActionResult Create(Team team)
  {
    Team.Post(team);
    return RedirectToAction("Index");
  }

  public ActionResult Edit(int id)
  {
    Team team = Team.GetDetails(id);
    return View(team);
  }

  [HttpPost]
  public ActionResult Edit(Team team)
  {
    Team.Put(team);
    return RedirectToAction("Details", new { id = team.TeamId });
  } 
}
