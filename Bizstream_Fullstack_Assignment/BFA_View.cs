@model ContactUS.ViewModel.ContactViewModel
@{
    ViewData["Title"] = "Home Page";
}
<script src="~/lib/jquery-validation/dist/jquery.validate.min.js"></script>
<script src="~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js"></script>
<link rel="stylesheet" href="~/lib/bootstrap/dist/css/bootstrap.min.css" />
<div>
    <div class="col-md-6">
        <div>
            @if (ViewBag.Message == null)
            {
                <div>
                    <form method="post">
                        <div class="form-group">
                            <label asp-for="First_Name">First_Name</label>
                            <input asp-for="First_Name" class="form-control" />
                            <span asp-validation-for="First_Name" 
                            class="text-muted"></span>
                        </div>
                        <div class="form-group">
                            <label asp-for="Last_Name">Last_Name</label>
                            <input asp-for="Last_Name" class="form-control" />
                            <span asp-validation-for="Last_Name" 
                            class="text-muted"></span>
                        </div>
                        <div class="form-group">
                            <label asp-for="Email">Email</label>
                            <input asp-for="Email" class="form-control" />
                            <span asp-validation-for="Email" 
                            class="text-muted"></span>
                        </div>
                        <div class="form-group">
                            <label asp-for="Message">Message</label>
                            <textarea rows="5" cols="15" 
                            asp-for="Message" class="form-control"></textarea>
                            <span asp-validation-for="Message" 
                            class="text-muted"></span>
                        </div>
                        <div>
                            <button type="submit" 
                            class="btn btn-success">Send </button>
                        </div>
                    </form>
                </div>
            }
        </div>
        <div>
            <div>
                @if (ViewBag.Message != null)
            {
                    <div>@ViewBag.Message</div>
                }
            </div>
        </div>
    </div>
</div>