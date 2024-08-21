using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Models;
using System.Linq;

namespace MyMvcApp.Controllers
{
    public class UserController : Controller
    {
        public static System.Collections.Generic.List<User> userlist = new System.Collections.Generic.List<User>();

        // GET: User
        public ActionResult Index(string searchTerm)
        {
            // If searchTerm is not null or empty, filter the user list
            var users = string.IsNullOrEmpty(searchTerm) 
                ? userlist 
                : userlist.Where(u => u.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();

            return View(users);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            // Retrieve the user from the userlist using the provided id
            var user = userlist.FirstOrDefault(u => u.Id == id);

            // Check if the user exists
            if (user == null)
            {
                // If the user does not exist, return a "Not Found" result
                return NotFound();
            }

            // If the user exists, pass the user details to the view
            return View(user);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            // Display the form to create a new user
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                // Add the new user to the userlist
                userlist.Add(user);

                // Redirect to the Index action to display the updated list of users
                return RedirectToAction("Index");
            }

            // If the model state is not valid, return the Create view with the user data
            return View(user);
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            // Retrieve the user from the userlist using the provided id
            var user = userlist.FirstOrDefault(u => u.Id == id);

            // Check if the user exists
            if (user == null)
            {
                // If the user does not exist, return a "Not Found" result
                return NotFound();
            }

            // If the user exists, pass the user details to the view
            return View(user);
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, User user)
        {
            if (ModelState.IsValid)
            {
                // Find the user in the userlist based on the provided ID
                var existingUser = userlist.FirstOrDefault(u => u.Id == id);

                // If the user is not found, return a HttpNotFoundResult
                if (existingUser == null)
                {
                    return NotFound();
                }

                // Update the user's information
                existingUser.Name = user.Name;
                existingUser.Email = user.Email;

                // Redirect to the Index action to display the updated list of users
                return RedirectToAction("Index");
            }

            // If the model state is not valid, return the Edit view with the user data
            return View(user);
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            // Retrieve the user from the userlist based on the provided ID
            var user = userlist.FirstOrDefault(u => u.Id == id);

            // If the user is not found, return a HttpNotFoundResult
            if (user == null)
            {
                return NotFound();
            }

            // Pass the user to the Delete view
            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            // Retrieve the user from the userlist based on the provided ID
            var user = userlist.FirstOrDefault(u => u.Id == id);

            // If the user is not found, return a HttpNotFoundResult
            if (user == null)
            {
                return NotFound();
            }

            // Remove the user from the userlist
            userlist.Remove(user);

            // Redirect to the Index action to display the updated list of users
            return RedirectToAction("Index");
        }

        // GET: User/Search
        public ActionResult Search(string searchTerm)
        {
            // Check if the search term is null or empty
            if (string.IsNullOrEmpty(searchTerm))
            {
                // If the search term is null or empty, return the full user list
                return View(userlist);
            }

            // Filter the user list based on the search term
            var filteredUsers = userlist.Where(u => u.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();

            // Return the filtered list of users to the view
            return View(filteredUsers);
        }
    }
}