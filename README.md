# TürkçeKod v10 🇹🇷

> **Türkçe sözdizimli, tarayıcıda çalışan programlama dili ve IDE**
> A Turkish-syntax programming language and IDE that runs entirely in the browser.

🌐 **Canlı / Live:** [https://seyyidkadir.github.io/TurkceKod/](https://seyyidkadir.github.io/TurkceKod/)

---

## 🇹🇷 Türkçe

### Nedir?
TürkçeKod, Türkçe anahtar kelimelerle kod yazmanızı sağlayan, tek bir HTML dosyasından oluşan programlama dili ve geliştirme ortamıdır. Kurulum gerektirmez — tarayıcıda açın, yazmaya başlayın.


##Proje hikayesi;
TürkçeKod’un temeli aslında 2012 yılına dayanıyor. Endüstri Meslek Lisesi’nde bilgisayar bölümü öğrencisiyken, sınıftaki herkes Console.WriteLine("Merhaba Dünya");
Yazarken ben “Acaba tamamen Türkçe komutlarla çalışan basit bir yorumlayıcı yapabilir miyim?” diye uğraşıyordum.
Hocalarıma gösterince sordular:
“Peki Kadir, bu dil ile neler yapılır?”
“Basit işlemler, spesifik şeyler pek olmaz” dedim.
“En azından bir ortalama hesaplasa?” diye sordular.
“Bakarım” dedim…
Ama 2013’te mezun olunca proje rafa kalktı.
Yıllar sonra aklıma birden geldi.
Eski kodları alıp Claude’a açtım, dilin geliştiğini görünce “Hadi canım” dedim ve hocama verdiğim “bakarız” sözü aklıma düştü.
O noktada düşündüm:
İngilizce bilmeyen çocuklar, lise öğrencileri ve programlamaya yeni başlayanlar için hâlâ bir ihtiyaç var. Scratch’ten sonra geçiş yapabilecekleri, tarayıcıda çalışan, Türkçe syntax’lı bir araç faydalı olabilir.
Syntax yapısını kendi geçmişimden karıştırdım: 
C/C++, Python, C#, Visual Basic 6 ve biraz Delphi/Pascal etkisiyle.
İlk versiyonda AI (Claude) lexer ve parser konusunda önerilerde bulundu, ben de denedim.
Daha sonra DeepSeek debug ve testlerde yardımcı oldu.
Ben de bizzat saatlerce test ettim – özellikle oyunlar (Snake, Tetris) ve uygulamalar çalışınca “Tamam, bu oldu” dedim.
Şu an v10’dayız.
Lexer ve parser tarafı hâlâ geliştirme aşamasında, eksikleri olduğunu biliyorum ve gerekirse baştan kendim yazacağım.
AI’yi sadece hızlandırıcı ve yardımcı araç olarak kullandım;
Temel fikir, tasarım kararları ve testlerin büyük kısmı bana ait.
Amacım profesyonel bir üretim dili yaratmak değil.
Amacım: Eğitimde İngilizce bariyerini azaltmak, yeni başlayanlara programlama mantığını kendi dilinde tattırmak.
Hataları, eksik syntax’leri veya önerilerinizi lütfen GitHub üzerinden bildirin.

##2012 versiyonu için Original/Kod_Yorumla.cs bakmanız yeterlidir. 
İlk kodum dur lisede iken yazmıştım 😊
Samimi feedback’leriniz benim için çok değerli.
Çünkü ileride bir hata olursa belki ben görmemişimdir diye sizden deneyip bilgi vermenizi istiyorum teşekkürler. 



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
