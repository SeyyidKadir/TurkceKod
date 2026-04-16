# TürkçeKod v10 🇹🇷

> **Türkçe sözdizimli, tarayıcıda çalışan programlama dili ve IDE**
> A Turkish-syntax programming language and IDE that runs entirely in the browser.

🌐 **Canlı / Live:** [https://seyyidkadir.github.io/TurkceKod/](https://seyyidkadir.github.io/TurkceKod/)

---

## 🇹🇷 Türkçe

### Nedir?
TürkçeKod, Türkçe anahtar kelimelerle kod yazmanızı sağlayan, tek bir HTML dosyasından oluşan programlama dili ve geliştirme ortamıdır. Kurulum gerektirmez — tarayıcıda açın, yazmaya başlayın.

### Kullanım
Tarayıcınızda açın → [https://seyyidkadir.github.io/TurkceKod/](https://seyyidkadir.github.io/TurkceKod/)

Ya da `index.html` dosyasını indirip doğrudan tarayıcınızda açabilirsiniz.

### Özellikler
- ✅ Türkçe sözdizimi (`Eger`, `Dongu`, `Fonksiyon`, `Sayi`, `Metin`...)
- 🪟 GUI desteği — Pencere, Düğme, Etiket, Kanvas, Zamanlayıcı ve daha fazlası
- 🧙 Proje Sihirbazı — birkaç adımda hazır proje iskeleti
- 🖼️ Form Tasarımcısı — sürükle-bırak GUI editörü
- 🎮 Oyun desteği — Kanvas + Zamanlayıcı ile gerçek oyunlar
- 🔊 Ses desteği — nota çalma, efektler
- 📡 Web / API — `VeriCek()` ile HTTP istekleri
- 💾 Veri saklama — LocalStorage, Çerez, JSON
- 🔍 Regex — tam düzenli ifade desteği
- 📦 Derleme — projenizi bağımsız HTML dosyasına derleyin
- 🎨 Sözdizimi renklendirme + otomatik tamamlama
- 📖 Kapsamlı yardım ve 13+ hazır örnek

### Örnek Kod
```
Sayi a = 10; Sayi b = 20;
Eger a < b Ise
  Yaz(a + " küçüktür " + b);
EgerBitti

Dongu i = 1 To 5 Adim 1
  Yaz(i + ". merhaba dünya!");
DonguBitti

Fonksiyon faktoriyel(n)
  Eger n <= 1 Ise  Don 1;  EgerBitti
  Don n * faktoriyel(n-1);
FonksiyonBitti

Yaz("5! = " + faktoriyel(5));
```

### Emeği Geçenler
| Kişi / Araç | Katkı |
|---|---|
| **AcizBirKul (Kadir Çakmak)** | Özgün fikir, algoritma, proje yönetimi |
| **Claude (Anthropic)** | Geliştirme |
| **DeepSeek** | Geliştirme |

---

## 🇬🇧 English

### What is it?
TürkçeKod is a programming language and IDE built entirely in a single HTML file. It lets you write code using Turkish keywords and runs directly in any modern browser — no installation, no setup.

### Usage
Open in your browser → [https://seyyidkadir.github.io/TurkceKod/](https://seyyidkadir.github.io/TurkceKod/)

Or download `index.html` and open it locally in any browser.

### Features
- ✅ Turkish syntax (`Eger`=if, `Dongu`=for, `Fonksiyon`=function, `Sayi`=int, `Metin`=string...)
- 🪟 GUI support — Window, Button, Label, Canvas, Timer and more
- 🧙 Project Wizard — scaffold a new project in seconds
- 🖼️ Form Designer — drag-and-drop GUI builder
- 🎮 Game support — real games with Canvas + Timer
- 🔊 Audio — play notes and sound effects
- 📡 Web / API — HTTP requests with `VeriCek()`
- 💾 Storage — LocalStorage, Cookies, JSON
- 🔍 Regex — full regular expression support
- 📦 Compile — export your project as a standalone HTML file
- 🎨 Syntax highlighting + autocomplete
- 📖 Full reference docs and 13+ ready-to-run examples

### Example Code
```
// Simple counter with GUI
Pencere pen;
pen.baslik = "Sayaç"; pen.genislik = 250; pen.yukseklik = 160;

Sayi sayac = 0;
Etiket et; et.yazi = "0"; et.x = 95; et.y = 20;
et.stil = "font-size:36px;font-weight:bold;color:#2ec4b6;";

Dugme btn; btn.yazi = "+1"; btn.x = 75; btn.y = 90;
btn.arkaplan = "yesil"; btn.renk = "beyaz";
btn.tiklaninca = Fonksiyon()
  sayac++;
  et.yazi = MetineKonvert(sayac);
FonksiyonBitti

pen.Ekle(et); pen.Ekle(btn);
pen.Goster();
```

### Credits
| Person / Tool | Contribution |
|---|---|
| **AcizBirKul (Kadir Çakmak)** | Original idea, algorithm, project ownership |
| **Claude (Anthropic)** | Development |
| **DeepSeek** | Development |

---

### Language Keyword Reference

| Turkish | English equivalent |
|---|---|
| `Sayi` | int |
| `Ondalik` | float |
| `Metin` | string |
| `Mantiksal` | boolean |
| `Dizi` | array |
| `Varyant` | var / any |
| `Eger...Ise...Degilse...EgerBitti` | if...else...end |
| `Dongu i = 0 To 10 Adim 1` | for i = 0 to 10 step 1 |
| `Suresince...Ise...SuresinceBitti` | while...do...end |
| `Tekrarla N Kez...TekrarlaBitti` | repeat N times |
| `Fonksiyon...FonksiyonBitti` | function...end |
| `Sinif...SinifBitti` | class...end |
| `Dene...Yakala...DeneBitti` | try...catch...end |
| `Don` | return |
| `Kes` | break |
| `Devam` | continue |
| `Yaz()` | print() |
| `Oku()` | input() |
| `Dogru / Yanlis` | true / false |
| `Ve / Veya / Degil` | and / or / not |

---

*© 2026 AcizBirKul (Kadir Çakmak) — TürkçeKod v10*
