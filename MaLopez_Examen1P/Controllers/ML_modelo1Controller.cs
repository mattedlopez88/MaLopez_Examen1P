using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MaLopez_Examen1P.Data;
using MaLopez_Examen1P.Models;

namespace MaLopez_Examen1P.Controllers
{
    public class ML_modelo1Controller : Controller
    {
        private readonly MaLopez_Examen1PContext _context;

        public ML_modelo1Controller(MaLopez_Examen1PContext context)
        {
            _context = context;
        }

        // GET: ML_modelo1
        public async Task<IActionResult> Index()
        {
            return View(await _context.ML_modelo1.ToListAsync());
        }

        // GET: ML_modelo1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mL_modelo1 = await _context.ML_modelo1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mL_modelo1 == null)
            {
                return NotFound();
            }

            return View(mL_modelo1);
        }

        // GET: ML_modelo1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ML_modelo1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Edad,Direccion,Departamento,FechaNacimiento,IsCliente,Saldo")] ML_modelo1 mL_modelo1)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mL_modelo1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mL_modelo1);
        }

        // GET: ML_modelo1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mL_modelo1 = await _context.ML_modelo1.FindAsync(id);
            if (mL_modelo1 == null)
            {
                return NotFound();
            }
            return View(mL_modelo1);
        }

        // POST: ML_modelo1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Edad,Direccion,Departamento,FechaNacimiento,IsCliente,Saldo")] ML_modelo1 mL_modelo1)
        {
            if (id != mL_modelo1.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mL_modelo1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ML_modelo1Exists(mL_modelo1.Id))
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
            return View(mL_modelo1);
        }

        // GET: ML_modelo1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mL_modelo1 = await _context.ML_modelo1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mL_modelo1 == null)
            {
                return NotFound();
            }

            return View(mL_modelo1);
        }

        // POST: ML_modelo1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mL_modelo1 = await _context.ML_modelo1.FindAsync(id);
            if (mL_modelo1 != null)
            {
                _context.ML_modelo1.Remove(mL_modelo1);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ML_modelo1Exists(int id)
        {
            return _context.ML_modelo1.Any(e => e.Id == id);
        }
    }
}
