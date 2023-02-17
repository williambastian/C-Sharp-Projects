# C# Group Project Code Summary

For two weeks I was part of a project to develop a website with CRUD functionality for a non-technical client. My team's goal was to create no-code CRUD functionality for the client through their web interface. 

I completed by project assignments using ASP.NET MVC and Entity Framework. This project allowed me to build functionality for a project that was already underway, and required coordination with senior staff throughout the project. I was able to utilize C#, HTML, CSS, and JavaScript in combination to achieve the desired results.

Because this project remains live, and is being performed as a saleable product for a client, I was asked to only include snippets of work rather than fully uploading the project. In the descriptions of each work item below, you can find excerpts of code I wrote for this project.

As I progressed through the project, I became more familiar with the code base and architecture patterns in use, which made my progress through later tasks more rapid. 

I moved from the Production section, to Production Photos, and then to the early stages of a Blog section, the last of which was likely handed off to a new team following the end of my time in the sprint.

The individual work items I completed are listed, and then summarized below.

###

# Story 1: Style Home Page

I created the Home Page layout per the client's requests. This included their company logo, an asymmetrical two column layout beneath the logo, and the sections within each column. The left column contained the "Spotlight" section, which showed poster images for upcoming stage productions, and the "Land Acknowledgement" section, which contained specific language provided by the client regarding the property. The right column contained a "Donations" section, with a button directing users to a separate donations page, and a "Sponsors" Section, with client-provided sponsor logos.

###

# Story 2: Create entity model and CRUD functionality for website's "Production" section. This section shows what Productions, aka stage plays, will be performed by the client, which is a performing arts theatre.

Using EntityFramework I created a scaffolded ProductionsController, which generated the basic CRUD pages for this section of the website.

Model: Production.cs

    namespace TheatreCMS3.Areas.Prod.Models
{
    public class Production
    {
        public int ProductionId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Playwright { get; set; }
        public int Runtime { get; set; }
        public DateTime OpeningDay { get; set; }
        public DateTime ClosingDay { get; set; }
        public DateTime ShowTimeEve { get; set; }
        public DateTime? ShowTimeMat { get; set; }
        public int Season { get; set; }
        public bool IsWorldPremiere { get; set; }
        public string TicketLink { get; set; }
        public bool IsCurrentlyShowing()
        {
            return (DateTime.Now >= OpeningDay && DateTime.Now <= ClosingDay);
        }
        
        //production photo property
        //public virtual Production Production
    }
}

###

# Story 3: Style the Create and Edit pages for the "Production" section. 

The Create and Edit pages for the Production section required styling in line with the client's style guide. Changes included adding a header above the form with updated text "Create Production,"; styling the Submit and Back to List buttons with the client's color palette and hover effects; adding placeholders to all input fields; placing form in a centered container; adding effects to the input fields such as borders and color changes when they are active. These style changes were primarily made using HTML and CSS.

# Example form field from Create.cs:

@using (Html.BeginForm())
{
    @Html.AntiForgeryToken()
    <div class="row justify-content-center">
        <div class="form-horizontal prod-create--formWrapper">

            <hr />
            @Html.ValidationSummary(true, "", new { @class = "text-danger" })
            <div class="form-group prod-create--createInputFields">
                @Html.LabelFor(model => model.Title, htmlAttributes: new { @class = "control-label col-md-2" })
                <div class="col-md-auto">

                    @Html.EditorFor(model => model.Title, new { htmlAttributes = new { placeholder = "Enter a title", @class = "form-control" } })
                    @Html.ValidationMessageFor(model => model.Title, "", new { @class = "text-danger" })
                </div>
            </div>

            <!--Rest of Create.cs follows -->
        </div>
    </div>
}

# Example CSS styling for prod-create--createInputFields:

.prod-create--createInputFields {
    width: 80%;
    margin: auto;
    max-width: 80%;
}

.prod-create--createInputFields input {
    background-color: lightgray;
}

.prod-create--createInputFields input:focus {
    border-color: var(--secondary-color);
    background-color: var(--light-color);
    box-shadow: var(--secondary-color) 5px;
    border: 4px solid var(--secondary-color);
}

###

# Story 4: Style the Index page for the "Production" section with bootstrap cards for each production, add buttons for delete / edit functionality that appear when hovering over a card for a specific Production. Clicking the card image links user to that specific production's details page.

<div class="card d-flex justify-content-center align-content-center prod-index--card">
    <a href="@Url.Action("Details", "Productions", new { id = item.ProductionId })" class="stretched-link" id="myLink" data-toggle="modal" data-target="#exampleModal-@item.ProductionId"></a>

    <!-- When production photos model is configured each production should show its specific photo -->

    <img src="~/Content/images/photo-Placeholder.jpg" class="card-img-top" alt="">


    <div class="card-body justify-content-center prod-index--cardBody">
        <p class="card-text">@Html.DisplayFor(modelItem => item.Title)</p>

        <div class="card-img-overlay d-flex align-items-center justify-content-center mt-5 prod-index--imgOverlay">
            <div class="d-flex justify-content-center prod-index--detailLink">
                <a href="@Url.Action("Edit", "Productions", new { id = item.ProductionId })" class="badge badge-pill prod-index--badge-Edit prod-index--overlayLinks">Edit</a>
                <a href="@Url.Action("Delete", "Productions", new { id = item.ProductionId })" class="badge badge-pill prod-index--badge-Delete prod-index--overlayLinks">Delete</a>
            </div>
        </div>
    </div>
</div>

###

# Story 5: Add search and pagination functionality to index of Production section.

# Search functionality in index.cshtml:

@using (Html.BeginForm("Index", "Productions", FormMethod.Get))
            {
                <p class="prod-index--searchBarLabel">
                    Find by Title: @Html.TextBox("SearchString", ViewBag.CurrentFilter as string)
                    <input type="submit" value="Search" class="prod-index--searchButton" />
                </p>
            }

# Pagination in index.cshtml:

<div class="prod-index--paginateWrapper">
        Page @(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber) of @Model.PageCount

        @Html.PagedListPager(Model, page => Url.Action("Index", new { page, sortOrder = ViewBag.CurrentSort, currentFilter = ViewBag.CurrentFilter }))
</div>

# Index() in ProductionsController.cs: (also contains sort functionality, which is commented out until later stage in project)

namespace TheatreCMS3.Areas.Prod.Controllers
{
    public class ProductionsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Prod/Productions
        public ViewResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            // begin sort functionality - sections that are commented out are sort by opening day functionality, which has not been tested. Sort by title is functional. Un Comment sort by title line in Prod\Views\Production\Index.cshtml to enable. //
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "title_desc" : "";
            //omit sort by opening date / age. Parameter could be opening day, closing day, etc
            //ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";//
            if (searchString != null)    //search bar functionality
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;
            var productions = from p in db.Productions
                              select p;
            if (!String.IsNullOrEmpty(searchString))           // sort by title functionality
            {
                productions = productions.Where(p => p.Title.Contains(searchString));
                                            
            }
            switch (sortOrder)
            {
                case "title_desc":
                    productions = productions.OrderByDescending(p => p.Title);
                    break;
                //case "Date":                                                           // sort by date functionality
                //    productions = productions.OrderBy(p => p.OpeningDay);
                //    break;
                //case "date_desc":
                //    productions = productions.OrderByDescending(p => p.OpeningDay);
                //    break;
                default:
                    productions = productions.OrderBy(p => p.Title);                 //default behavior: list titles alphabetically
                    break;
            }
            int pageSize = 8;       //max number of cards per page. currently displays as a 2 row by 4 card grid before paginating.
            int pageNumber = (page ?? 1);
            
            return View(productions.ToPagedList(pageNumber, pageSize)); // changed from db.Productions.ToList
        
###

# Story 6: 
Change details page functionality to be a modal pop-up instead of a link to a separate page. When clicking a production's card, a modal with that production's details is shown. The class "stretched-link" is used to create an <a href> for the entire card body. Bootstrap 4.6 used for modal classes.

Modal functionality from Index.cs, with logic to show each item's details:

@foreach (var item in Model)
        {
            <div class="modal fade" id="exampleModal-@item.ProductionId" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
                <div class="modal-dialog">
                    <div class="modal-content prod-index--modalContent">
                        <div class="modal-header">
                            <h5 class="modal-title" id="exampleModalLabel">Details</h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            

                            <dl class="dl-horizontal">
                                <dt>
                                    @Html.DisplayNameFor(modelItem => item.Title)
                                </dt>

                                <dd>
                                    @Html.DisplayFor(modelItem => item.Title)
                                </dd>

                                <!-- entries continue for every field in the model-->

                            </dl>

                            <p>
                                @Html.ActionLink("Edit", "Edit", new { id = item.ProductionId }) |
                                @Html.ActionLink("Back to List", "Index")
                            </p>
                        </div>
                        <div class="modal-footer align-content-center justify-content-center prod-index--modalCloseButton">
                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                            
                        </div>
                    </div>
                </div>
            </div>
            
            <div class="col-md-3">

                <div class="card d-flex justify-content-center align-content-center prod-index--card">
                    <a href="@Url.Action("Details", "Productions", new { id = item.ProductionId })" class="stretched-link" id="myLink" data-toggle="modal" data-target="#exampleModal-@item.ProductionId"></a>

                    <!--When production photos model is configured each production should show its specific photo-->
                    <img src="~/Content/images/photo-Placeholder.jpg" class="card-img-top" alt="">


                    <div class="card-body justify-content-center prod-index--cardBody">
                        <p class="card-text">@Html.DisplayFor(modelItem => item.Title)</p>


                        <div class="card-img-overlay d-flex align-items-center justify-content-center mt-5 prod-index--imgOverlay">


                            <div class="d-flex justify-content-center prod-index--detailLink">
                                <a href="@Url.Action("Edit", "Productions", new { id = item.ProductionId })" class="badge badge-pill prod-index--badge-Edit prod-index--overlayLinks">Edit</a>
                                <a href="@Url.Action("Delete", "Productions", new { id = item.ProductionId })" class="badge badge-pill prod-index--badge-Delete prod-index--overlayLinks">Delete</a>
                            </div>

                        </div>

                    </div>

                </div>

            </div>
        }



###

# Story 7 & 8: Create a new user type called Production Manager, which will eventually act as an admin user for the Production section of the website. Create a new model for ProductionManager that extends from ApplicationUser. 

# Seed the project database with a ProductionManager user. Create a static seed method that saves a ProductionManager to the database before the page loads, so that the seeded user can be used for testing. 

ProductionManager.cs shows model for ProductionManager and Seed method:

namespace TheatreCMS3.Areas.Prod.Models
{
    public class ProductionManager : ApplicationUser
    {
        public string Title { get; set; }
        public DateTime ManagerStartDate { get; set; }

        // Create a roleManager variable - modeled on process for Blog/Models/HeadAuthor.cs

        // RoleManager<IdeitityRole> is a manager of IdentityRoles(identity roles can be found in the table AspNetRoles)
        // RoleManager's constructor takes a 'store' parameter which is of type IRoleStore<TRole, string>.
        // So we're creating a new store to pass to it using our database context so we can perform actions on it.
        // The RoleStore is a concrete implementation of the IRoleStore interface, and provides us with basic functionality for
        // storing and retrieving roles.

        public static void SeedProductionManager(ApplicationDbContext db)
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));

            // Check if role already exists first - if it does, we don't have to do anything else
            if (!roleManager.RoleExists("ProductionManager"))
            {
                //Using roleManager, create new role called "ProductionManager"
                var roleCreated = roleManager.Create(new IdentityRole("ProductionManager"));

                // double check that the role creation step of the process is completed before moving on.
                if (roleCreated.Succeeded)
                {
                    // Next, we'll create our userManager - we need to be able to add to the AspNetUsers table also, and this will allow us to do so.
                    // The syntax is the same, except that we're managing users instead of roles.
                    var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));

                    // Create a new ProductionManager (extended from ApplicationUser) to store
                    var productionManager = new ProductionManager
                    {
                        UserName = "productionManager",
                        Title = "Production Manager",
                        ManagerStartDate = new DateTime(2023, 02, 01)
                    };

                    var password = "testLoginProductionManager";

                    // the .Create method accepts a password assignment parameter, but we are not providing one at this time.
                    var productionManagerCreated = userManager.Create(productionManager, password);

                    if (productionManagerCreated.Succeeded)
                    {
                        // To add a role, we need the user id and the role name.
                        // We will use the id of the user we just created.
                        // To use the whole user object:
                        var productionManagerUser = userManager.FindByName("productionManager");
                        // pass the id of this user and the role we want it to have, "ProductionManager," which we just created above
                        userManager.AddToRole(productionManagerUser.Id, "ProductionManager");
                    }
                }
            }
        }
    }
}

The method is called in the Configuration.cs Seed() method:

internal sealed class Configuration : DbMigrationsConfiguration<TheatreCMS3.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            // Seed the ProductionManager user
            ProductionManager.SeedProductionManager(context);
        }
    }

###
 
# Story 9: Restrict CRUD operations to only ProductionManager users. Redirect non-authorized users to an "Access Denied" page. 

Example Edit() method in ProductionsController.cs, restricted to ProductionManager users with [ProductionAuthorize(Roles = "ProductionManager")] :

// GET: Prod/Productions/Edit/5
        [ProductionAuthorize(Roles = "ProductionManager")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Production production = db.Productions.Find(id);
            if (production == null)
            {
                return HttpNotFound();
            }
            return View(production);
        }

Method to re-direct unauthorized users to "Access Denied" page:

public class ProductionAuthorize : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new RedirectResult("/Prod/Productions/AccessDenied");
        }
    }



###
 
Story 10: Create an easy, one-click login button to log in as ProductionManager. I created a partial view for the easy login button, and then referenced it in the project-wide layout file, for testing purposes. In production this would be removed from the project-wide layout.

The partial view _LoginBtnProductionManager.cshtml:

@{          
    var productionManagerLoginViewModel = new LoginViewModel
    {
      EmailOrUsername = "productionManager",
      Password = "testLoginProductionManager",
      RememberMe = false
    };
}

<form action=@Url.Action("Login", "Account", new { area = ""}) method="post">
    @Html.AntiForgeryToken()
    <input type="hidden" name="returnUrl" value=@HttpContext.Current.Request.Url.AbsolutePath />
    <input type="hidden" name="EmailOrUsername" value=@productionManagerLoginViewModel.EmailOrUsername />
    <input type="hidden" name="Password" value=@productionManagerLoginViewModel.Password />
    <button type="submit" class="font-weight-bold rounded cms-bg-main cms-text-light prod-index--easyLoginBtn">Log in as Production Manager</button>
</form>

###
 
# Story 11: Create entity model for Production Photos with CRUD functionality

Model Snippet for ProductionPhoto.cs:

namespace TheatreCMS3.Areas.Prod.Models
{
    public class ProductionPhoto
    {
        public int ProductionPhotoId { get; set; }
        public byte[] PhotoFile { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}

Using EntityFramework I created the ProductionPhotosController and the associated default CRUD pages.

###
 
# Story 12: Create photo storage and retrieval for ProductionPhotos. Convert uploaded images to byte arrays, store in photo database, then retrieve and convert back to image to display on View.

The Create() method in ProductionPhotosController.cs performs the conversion to a byte array:

// POST: Prod/ProductionPhotos/Create
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductionPhotoId,PhotoFile,Title,Description")] ProductionPhoto productionPhoto, HttpPostedFileBase postedFile)
        {
            if (ModelState.IsValid)
            {
                productionPhoto.PhotoFile = ConvertImageToByte(postedFile);
                db.ProductionPhotoes.Add(productionPhoto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(productionPhoto);
        }

On the Production Photo Index page, this is converted back to an image:

@foreach (var item in Model) {
    <tr>
        <td>
            @Html.DisplayFor(modelItem => item.Title)
        </td>
        <td>
            <img src="data:image/jpg;base64, @Convert.ToBase64String(item.PhotoFile)" />
        </td>
        <td>
            @Html.DisplayFor(modelItem => item.Description)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", new { id=item.ProductionPhotoId }) |
            @Html.ActionLink("Details", "Details", new { id=item.ProductionPhotoId }) |
            @Html.ActionLink("Delete", "Delete", new { id=item.ProductionPhotoId })
        </td>
    </tr>
}

###
 
# Story 13: Photo Preview. When user selects image they would like to upload on the create or edit page, show image preview next to upload button.

From the photo upload section of the Create form, we reference JavaScript in the file Prod.js to help generate the photo preview. Excerpt from Create.cs:

<div class="form-group">
        @Html.LabelFor(model => model.PhotoFile, htmlAttributes: new { @class = "control-label col-md-2" })
        <div class="col-lg-auto m-sm-2 prodphoto-create--photoPreviewContainer">
            @Html.TextBoxFor(model => model.PhotoFile, new { type = "file", Name = "postedFile", onchange= "javascript:filePreviewOnChange(); return false;", id ="uploadImage", accept = "image/*"  })
            <img src="" class="" alt="Upload Preview" id="uploadPreview" />
            @Html.ValidationMessageFor(model => model.PhotoFile, "", new { @class = "text-danger" })
        </div>
    </div>
    ...
    @section Scripts {
    @Scripts.Render("~/bundles/jqueryval")
    @Scripts.Render("~/Scripts/Areas/Prod.js")

The functionality in Prod.js:

function filePreviewOnChange() {
    var fileInput = document.getElementById("uploadImage")
    fileInput.style.color = "rgba(0,0,0,0)";
    const [file] = fileInput.files;
    if (file) {
        var photo = URL.createObjectURL(file);
        $("#uploadPreview").attr("src", photo);
    }
}


###
 
# Story 14: Create Comment model and CRUD pages for Blog section.

The model Comment.cs, used with EntityFramework to scaffold  CommentsController.cs and default CRUD pages:

namespace TheatreCMS3.Areas.Blog.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string Author { get; set; }
        public DateTime CommentDate { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }

        public Comment()
        {
            CommentDate = DateTime.Now;
        }

        public double LikeRatio()
        {
            return (Likes / (Likes + Dislikes)) * 100;
        }
    }
}

###
 
# Story 15: Create partial view for comments, so that these can be displayed on multiple pages.

The partial view created for Blog comments, to assist with displaying comments on multiple pages across the website:

@model IEnumerable<TheatreCMS3.Areas.Blog.Models.Comment>

<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(model => model.Author)
        </th>
        <th>
            @Html.DisplayNameFor(model => model.CommentDate)
        </th>
        <th>
            @Html.DisplayNameFor(model => model.Likes)
        </th>
        <th>
            @Html.DisplayNameFor(model => model.Dislikes)
        </th>
        <th></th>
    </tr>

    @foreach (var item in Model)
    {
        <tr>
            <td>
                @Html.DisplayFor(modelItem => item.Author)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.CommentDate)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.Likes)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.Dislikes)
            </td>
            <td>
                @Html.ActionLink("Edit", "Edit", new { id = item.CommentID }) |
                @Html.ActionLink("Details", "Details", new { id = item.CommentID }) |
                @Html.ActionLink("Delete", "Delete", new { id = item.CommentID })
            </td>
        </tr>
    }

</table>


###




