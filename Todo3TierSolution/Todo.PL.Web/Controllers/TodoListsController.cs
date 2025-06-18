using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using Todo.BLL.Interfaces;
using Todo.DAL.Context;
using Todo.DAL.Entities;
using Todo.DAL.Entities.Enums;

namespace Todo.PL.Web.Controllers
{
    public class TodoListsController : Controller
    {
        private readonly ITodoListRepository _context;

        public TodoListsController(ITodoListRepository context)
        {
            _context = context;
        }

        // GET: TodoLists
        public async Task<IActionResult> Index()
        {
            return View(await _context.GetAllWithCategory());
        }

        // GET: TodoLists/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var todoList = await _context.GetByIdWithCategory(id);
            if (todoList == null)
            {
                return NotFound();
            }

            return View(todoList);
        }

        // GET: TodoLists/Create
        public async Task<IActionResult> Create()
        {
            var catagories = await _context.GetAllCatagories();
            ViewData["CatagoryId"] = new SelectList(catagories, "Id", "Name");
            ViewBag.PriorityList = new SelectList(Enum.GetValues(typeof(Priority)));
            return View();
        }

        // POST: TodoLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Description,IsCompleted,Priority,Deadline,CatagoryId,Id")] TodoList todoList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(todoList);
                await _context.SaveChangesAsyncronised();
                return RedirectToAction(nameof(Index));
            }
            var catagories = await _context.GetAllCatagories();
            ViewData["CatagoryId"] = new SelectList(catagories, "Id", "Name", todoList.CatagoryId);
            ViewBag.PriorityList = new SelectList(Enum.GetValues(typeof(Priority)));
            return View(todoList);
            //return RedirectToAction("Index");
        }

        // GET: TodoLists/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var todoList = await _context.GetById(id);
            if (todoList == null)
            {
                return NotFound();
            }
            var catagories = await _context.GetAllCatagories();
            ViewData["CatagoryId"] = new SelectList(catagories, "Id", "Name", todoList.CatagoryId);
            ViewBag.PriorityList = new SelectList(Enum.GetValues(typeof(Priority)));
            return View(todoList);
        }

        // POST: TodoLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Title,Description,IsCompleted,Priority,Deadline,CatagoryId,Id")] TodoList todoList)
        {
            if (id != todoList.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(todoList);
                    await _context.SaveChangesAsyncronised();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await _context.TodoListExists(todoList.Id))
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
            var catagories = await _context.GetAllCatagories();
            ViewData["CatagoryId"] = new SelectList(catagories, "Id", "Name", todoList.CatagoryId);
            ViewBag.PriorityList = new SelectList(Enum.GetValues(typeof(Priority)));
            return View(todoList);
        }

        // GET: TodoLists/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var todoList = await _context.GetById(id);
            if (todoList == null)
            {
                return NotFound();
            }

            return View(todoList);
        }

        // POST: TodoLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var todoList = await _context.GetById(id);
            if (todoList != null)
            {
                _context.Delete(todoList);
            }

            await _context.SaveChangesAsyncronised();
            return RedirectToAction(nameof(Index));
        }

        //private bool TodoListExists(int id)
        //{
        //    return _context.Todos.Any(e => e.Id == id);
        //}
    }
}
