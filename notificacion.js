/*
Push.create("Holi", {
  body: "Holi, raza'?",
  icon: 'assets/ico.png',
  timeout: 10000,
  onClick: function() {
    window.focus();
    this.close();
  }
});
 */

var btn = document.getElementById('btn');
btn.addEventListener('click', function() {
  Push.create("Holi", {
    body: "Holi, raza",
    icon: 'assets/icoo.png',
    timeout: 5000,
    onClick: function() {
      window.focus();
      this.close();
    }
  });
})
