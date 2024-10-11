const lamp = document.getElementById("lamp");
const light = document.getElementById("light");
const videoContainer = document.getElementById("videoContainer");
const container = document.getElementById("container");

lamp.addEventListener("click", () => {
  gsap.to("body", {
    background: "linear-gradient(120deg, #2C3E50, #000000)",
    duration: 1,
  });
  gsap.to(container, { backgroundColor: "rgba(0, 0, 0, 0.5)", duration: 1 });
  gsap.to(lamp, {
    opacity: 0,
    duration: 0.5,
    onComplete: () => (lamp.style.display = "none"),
  });
  light.style.display = "block";
  gsap.fromTo(
    light,
    { scale: 0, opacity: 0 },
    { scale: 1, opacity: 0.7, duration: 1, ease: "power2.out" }
  );

  setTimeout(() => {
    gsap.to(light, {
      opacity: 0,
      duration: 0.5,
      onComplete: () => (light.style.display = "none"),
    });

    // Iniciar el video automáticamente
    videoContainer.style.display = "block";
    const iframe = videoContainer.querySelector("iframe");
    iframe.src += "?autoplay=1"; // Agregar el parámetro de autoplay al iframe
  }, 1500);
});
