using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SIGNA.Models;

namespace SIGNA.Controllers
{
    public class ListaController : Controller
    {
        private readonly PessoaContext _context;

        public ListaController(PessoaContext context)
        {
            _context = context;
        }

        // GET: Lista
        public async Task<IActionResult> Index()
        {
              return View(await _context.PESSOA.ToListAsync());
        }

        // GET: Lista/Edit/
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PESSOA == null)
            {
                return NotFound();
            }

            var dataModel = await _context.PESSOA.FindAsync(id);
            if (dataModel == null)
            {
                return NotFound();
            }
            return View(dataModel);
        }

        // POST: Lista/Edit/
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PESSOA_ID,NOME_FANTASIA,CNPJ_CPF")] DataModel dataModel)
        {
            if (id != dataModel.PESSOA_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dataModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DataModelExists(dataModel.PESSOA_ID))
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
            return View(dataModel);
        }

        private bool DataModelExists(int id)
        {
          return _context.PESSOA.Any(e => e.PESSOA_ID == id);
        }
    }
}
