document.write(`
<header class="navbar navbar-expand navbar-dark sticky-top flex-column flex-md-row">
  <a class="navbar-brand" href="#">
    <img src="" id="navbar-logo" width=100% height=100% />
  </a>
  <div class="navbar-nav-scroll">
    <ul class="navbar-nav bd-navbar-nav flex-row">
      <li class="nav-item active">
        <a class="nav-link" href="/">Home</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="discover">Discover</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="subscriptions">Subscriptions</a>
      </li>
    </ul>
  </div>
  <form class="form-inline my-2 my-lg-0 ml-auto">
    <input class="form-control mr-sm-2" type="search" placeholder="Find a channel" aria-label="Search">
    <button class="btn btn-danger my-2 my-sm-0" type="submit">Search</button>
  </form>
</header>
<script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
`);
document.getElementById("navbar-logo").src = window.location.protocol + "//" + window.location.host + "/branding/regular/logo.svg";
