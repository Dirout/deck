---
title: deck
layout: default
---
<head>
  <title>{{ page.title }}</title>
  {% inc head.html %}
</head>

<body>
  {% inc navbar.html %}
  <ul>
  {% for channel in channels.entries %}
  <li><a href="{{ channel.url | prepend: site.url }}">{{ channel.title }}</a></li>
  {% endfor %}
  </ul>
  {% inc firebase.html %}
  {% inc auth.html %}
</body>
