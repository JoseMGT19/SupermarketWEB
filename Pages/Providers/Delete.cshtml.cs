using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Providers
{
	public class DeleteModel : PageModel
	{
		private readonly SupermarketContext _context;

		public DeleteModel(SupermarketContext context)
		{
			_context = context;
		}

		[BindProperty]
		public Provider Providers { get; set; } = default!;

		public async Task<IActionResult> OnGetAsync(int? id)
		{
			if (id == null || _context.Providers == null)
			{
				return NotFound();
			}
			var providers = await _context.Providers.FindAsync(id);

			if (providers != null)
			{
				Providers = providers;
				_context.Providers.Remove(Providers);
				await _context.SaveChangesAsync();

			}
			return RedirectToPage("./Index");
		}
	}
}
