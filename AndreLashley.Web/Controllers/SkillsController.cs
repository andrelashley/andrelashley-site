
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AndreLashley.Web.Models;

public class SkillsController : Controller
{
    private readonly DataContext _context;

    public SkillsController(DataContext context)
    {
        _context = context;
    }

    // GET: SKILLS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Skills.ToListAsync());
    }

    // GET: SKILLS/Details/5
    public async Task<IActionResult> Details(System.Guid? skillid)
    {
        if (skillid == null)
        {
            return NotFound();
        }

        var skill = await _context.Skills
            .FirstOrDefaultAsync(m => m.SkillId == skillid);
        if (skill == null)
        {
            return NotFound();
        }

        return View(skill);
    }

    // GET: SKILLS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: SKILLS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("SkillId,Title,PercentUtilized")] Skill skill)
    {
        if (ModelState.IsValid)
        {
            _context.Add(skill);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(skill);
    }

    // GET: SKILLS/Edit/5
    public async Task<IActionResult> Edit(System.Guid? skillid)
    {
        if (skillid == null)
        {
            return NotFound();
        }

        var skill = await _context.Skills.FindAsync(skillid);
        if (skill == null)
        {
            return NotFound();
        }
        return View(skill);
    }

    // POST: SKILLS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(System.Guid? skillid, [Bind("SkillId,Title,PercentUtilized")] Skill skill)
    {
        if (skillid != skill.SkillId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(skill);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SkillExists(skill.SkillId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(skill);
    }

    // GET: SKILLS/Delete/5
    public async Task<IActionResult> Delete(System.Guid? skillid)
    {
        if (skillid == null)
        {
            return NotFound();
        }

        var skill = await _context.Skills
            .FirstOrDefaultAsync(m => m.SkillId == skillid);
        if (skill == null)
        {
            return NotFound();
        }

        return View(skill);
    }

    // POST: SKILLS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(System.Guid? skillid)
    {
        var skill = await _context.Skills.FindAsync(skillid);
        if (skill != null)
        {
            _context.Skills.Remove(skill);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool SkillExists(System.Guid? skillid)
    {
        return _context.Skills.Any(e => e.SkillId == skillid);
    }
}
