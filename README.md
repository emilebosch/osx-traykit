# OSX-Traykit in Xamarin

Embed simple sites in your tray! Inspired by the excellent menubar-webkit.


## Exposed JS methods

Following methods are exposed to control the traykit from JS via the `window.tray` 

Show the tray

```
window.tray.show()
```

Hide the tray

```
window.tray.window.hide()
```

Make the tray permanent

```
window.tray.setPinned(true/false)
```

Set the user agent

```
window.tray.setUserAgent('useragentstring')
```

Alert the user

````
window.tray.alert('title','message')
````

Send a notificaiton to the notification center

```
window.tray.notify('title','message')
```

Set a hotkey

```
window.tray.setHotkey({key:'', cb: func(){})
```
