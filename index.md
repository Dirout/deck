---
title: deck
layout: default
---
<head>
  <title>{{ page.title }}</title>
  {% inc head.html %}
</head>

<body>
<div class="user-bar">
  <a id="sign-in" href=""></div>
  <a href="{{ site.url }}/me"><img id="account-image" src=""></img></a>
</div>
  <ul>
  {% for channel in channels.entries %}
  <li><a href="{{ channel.url | prepend: site.url }}">{{ channel.title }}</a></li>
  {% endfor %}
  </ul>
  {% inc firebase.html %}
  {% inc auth.html %}
</body>
