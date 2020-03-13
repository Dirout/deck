---
title: deck
layout: default
---
<head>
  <title>{{ page.title }}</title>
  {% include head.html %}
  {% include auth.html %}
</head>

<body>
  <div id="sign-in-status"></div>
  <div id="sign-in"></div>
  <pre id="account-details"></pre>
  <ul>
  {% for channel in channels.entries %}
  <li><a href="{{ channel.url | prepend: site.url }}">{{ channel.title }}</a></li>
  {% endfor %}
  </ul>
</body>
