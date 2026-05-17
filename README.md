# TürkçeKod v14 🇹🇷

> **Türkçe sözdizimli, tarayıcıda çalışan programlama dili ve IDE**
> A Turkish-syntax programming language and IDE that runs entirely in the browser.

🌐 **Canlı / Live:** [https://seyyidkadir.github.io/TurkceKod/](https://seyyidkadir.github.io/TurkceKod/)

---

## 🇹🇷 Türkçe

### Nedir?

TürkçeKod, Türkçe anahtar kelimelerle kod yazmanızı sağlayan, tek bir HTML dosyasından oluşan programlama dili ve geliştirme ortamıdır. Kurulum gerektirmez — tarayıcıda açın, yazmaya başlayın.

---

## Proje Hikayesi

TürkçeKod'un temeli aslında **2012 yılına** dayanıyor.

Endüstri Meslek Lisesi'nde bilgisayar bölümü öğrencisiyken, sınıftaki herkes `Console.WriteLine("Merhaba Dünya");` yazarken ben *"Acaba tamamen Türkçe komutlarla çalışan basit bir yorumlayıcı yapabilir miyim?"* diye uğraşıyordum.

Hocalarıma gösterince sordular:
> *"Peki Kadir, bu dil ile neler yapılır?"*
> *"Basit işlemler, spesifik şeyler pek olmaz"* dedim.
> *"En azından bir ortalama hesaplasa?"* diye sordular.
> *"Bakarım"* dedim…

Ama 2013'te mezun olunca proje rafa kalktı.

Yıllar sonra aklıma birden geldi. Eski kodları alıp Claude'a açtım, dilin geliştiğini görünce *"Hadi canım"* dedim ve hocama verdiğim *"bakarız"* sözü aklıma düştü.

O noktada düşündüm: İngilizce bilmeyen çocuklar, lise öğrencileri ve programlamaya yeni başlayanlar için hâlâ bir ihtiyaç var. Scratch'ten sonra geçiş yapabilecekleri, tarayıcıda çalışan, Türkçe syntax'lı bir araç faydalı olabilir.

Syntax yapısını kendi geçmişimden karıştırdım: C/C++, Python, C#, Visual Basic 6 ve biraz Delphi/Pascal etkisiyle.

İlk versiyonda AI (Claude) lexer ve parser konusunda önerilerde bulundu, ben de denedim. Daha sonra DeepSeek debug ve testlerde yardımcı oldu. Ben de bizzat saatlerce test ettim — özellikle oyunlar (Snake, Tetris) ve uygulamalar çalışınca *"Tamam, bu oldu"* dedim.

AI'yi sadece hızlandırıcı ve yardımcı araç olarak kullandım. Temel fikir, tasarım kararları ve testlerin büyük kısmı bana ait.

**Amacım profesyonel bir üretim dili yaratmak değil.**
Amacım: Eğitimde İngilizce bariyerini azaltmak, yeni başlayanlara programlama mantığını kendi dilinde tattırmak.

> 📁 2012'deki ilk kod için: `Original/Kod_Yorumla.cs` — Lisede yazdığım ilk yorumlayıcı 😊

---

## v14'te Neler Var?

v10'dan bu yana çok şey değişti. İşte v14 ile gelen her şey:

### 🎨 Görünüm & Editör
- **VS2022 Dark teması** varsayılan — VS2022 Light, Monokai, Dracula, Solarized Dark seçenekleri
- **Açılış Splash ekranı** — Yeni Proje, Dosya Aç, Boş Başlat seçenekleri
- **VS2022 menü şeridi** — Dosya, Düzenle, Kütüphane, Sihirbaz, Debug, Yardım
- **Alt StatusBar** — Satır/Sütun göstergesi + 🎨 Tema seçici
- **Editör satır kaydırma** — Uzun satırlar artık düzgün görünüyor (`pre-wrap`)
- Tema seçimi LocalStorage'a kaydedilir, sayfa yenilenince korunur

### 🗣️ Dil & Parser
- **Anonim (anonymous) fonksiyon** — her yerde kullanılabilir
  ```
  // Parametre olarak geç
  DiziFiltrele(liste, Fonksiyon(x) Don x > 5; FonksiyonBitti)

  // Hemen çalıştır (IIFE)
  Yaz(Fonksiyon(a, b) Don a + b; FonksiyonBitti(10, 20))  // → 30

  // Closure — dış değişkeni görür
  Sayi k = 3;
  Varyant fn = Fonksiyon(x) Don x * k; FonksiyonBitti;
  Yaz(fn(7));  // → 21
  ```
- **Zincir erişim** — `dd1[0].isim`, `liste[i].deger`, `sonuc[0].metod()` artık çalışıyor
- **Daha anlaşılır hata mesajları** — `"RP bulundu"` yerine `kapama parantezi ")" bekleniyor, açılan "(" kapatılmamış` gibi
- SQL string içinde **çok satırlı yazım** desteklenir

### 🗄️ Veritabanı — İki Ayrı Sistem
- **`VTAc(isim)`** → Gerçek SQLite (sql.js, internet gerektirir)
- **`VTOAc(isim)`** → Offline Türkçe SQL (internet gerekmez, IndexedDB'de saklar)
  - Türkçe SQL: `TABLO_OLUSTUR`, `EKLE`, `SEC HEPSI`, `NEREDE`, `GUNCELLE`, `SIL`, `SIRALA`, `SINIR`…
  - **Parametreli sorgular** → SQL injection koruması: `VTSorgu(db, "SEC ... NEREDE yas > ?", [18])`
  - İnternetsiz `VTAc` denerseniz yorumlayıcı hemen `VTOAc` önerir

### 📦 Kütüphane Ekosistemi
- **Kütüphane Merkezi** — menüden `📦 Kütüphane` ile açılır
- 6 yerleşik kütüphane: Matematik Plus, Metin Araçları, Tarih Araçları, Dizi Araçları Plus, Renk Araçları, Doğrulama Araçları
- **`.tklib` formatı** — JSON tabanlı kütüphane paketi
  - `📥 .tklib Yükle` — dosyadan içe aktar
  - `📤 .tklib İndir` — yazdığın kütüphaneyi paylaş
  - `📦 Lib Aktar` — aktif sekmeyi `.tklib` olarak dışa aktar
- Kütüphane yüklenince **yeni sekmede** açılır, mevcut koda karışmaz
- Kendi kütüphaneni yaz, toplulukla paylaş

### 🖼️ Resim & Grafik
- **`ResimBase64Yukle(url)`** — URL'yi base64'e dönüştürür (internet bağımlı değil sonrası)
- **`ResimGom(kv, format?, kalite?)`** — Kanvası PNG/JPEG base64 string olarak dışa aktarır
- `ResimYukle()` artık `data:` ve `blob:` URL'leri sorunsuz kabul ediyor

### 🪟 Pencere Kontrol
- **`Buyut()` / `Kucult()` / `Geri()`** — önceki konumu kaydeder, geri döner
- **`KontrolGoster()` / `KontrolGizle()`** — `Goster()` öncesi veya sonrası çağrılabilir
- **`SuruklenebilirYap()`** — `Goster()` öncesi çağrılsa bile çalışır (`_surukPending` kuyruğu)
  ```
  btn.SuruklenebilirYap(pen);  // btn sürüklenince pen hareket eder
  pen.Goster();  // sonra göster — düzgün çalışır
  ```

### 💾 Proje & Dosya
- **Proje kaydet** (`.tkodp`) — aktif sekmenin son hali kaydedilir, modüller eksiksiz dahil
- **Proje aç** — `.tkodp`, `.tkodp.txt`, `.tkodp.json` hepsini açar (tarayıcının eklediği uzantılar sorun yaratmaz)
- Dosya indirmede `application/octet-stream` — tarayıcı artık `.txt` veya `.json` eklemez

### 🔨 Derleyici
- Derlenmiş HTML artık **sadece yorumlayıcıyı** içeriyor — IDE kodu, editör, modül sistemi dahil edilmiyor
- `</script>` string literalleri kaçırılıyor — derlenmiş sayfada erken kapanma yok
- `START_CODE is not defined`, `_ed is not defined` hataları giderildi

### 📖 API Referansı
- Ayrı bir `TurkceKod_API_Referans.html` dosyası — Microsoft Docs tarzı
- 22 bölüm, arama, tıklanınca açılan detaylı fonksiyon kartları
- Her fonksiyon için parametreler, dönüş tipi, kod örneği

---

## Kullanım

Tarayıcınızda açın → [https://seyyidkadir.github.io/TurkceKod/](https://seyyidkadir.github.io/TurkceKod/)

Ya da `index.html` dosyasını indirip doğrudan tarayıcınızda açabilirsiniz.

---

## Özellikler (Tam Liste)

- ✅ Türkçe sözdizimi (`Eger`, `Dongu`, `Fonksiyon`, `Sayi`, `Metin`…)
- 🪟 GUI — Pencere, Düğme, Etiket, Kanvas, Zamanlayıcı, Liste, Kaydırıcı, WebTarayıcı…
- 🧙 Proje Sihirbazı — birkaç adımda hazır iskelet
- 🖼️ Form Tasarımcısı — sürükle-bırak GUI editörü
- 🎮 Oyun motoru — 60fps döngü, çarpışma, tuş/fare yönetimi
- 🧊 3D Grafik — Three.js tabanlı Kanvas3D
- 🔊 Ses — nota çalma, efektler
- 🗄️ Veritabanı — SQLite (online) + Türkçe SQL (offline)
- 📡 Ağ — `VeriCek()`, `PostGonder()`, WebSocket
- 💾 Depolama — LocalStorage, Çerez, JSON, Dosya
- 🔐 Şifreleme — MD5, SHA256, Base64, Caesar, XOR, ROT13
- 🔍 Regex — tam düzenli ifade desteği
- 📦 Derleme — bağımsız HTML'ye derle
- 📦 Kütüphane ekosistemi — `.tklib` formatı ile paylaş
- 🎨 5 tema — VS2022 Dark/Light, Monokai, Dracula, Solarized
- 🐛 Debugger — breakpoint, adım adım çalıştırma
- 📖 API Referansı — ayrı dokümantasyon sitesi

---

## Örnek Kod

```
Sayi a = 10; Sayi b = 20;
Eger a < b Ise
  Yaz(a + " küçüktür " + b);
EgerBitti

Dongu i = 1 To 5 Adim 1
  Yaz(i + ". merhaba dünya!");
DonguBitti

Fonksiyon faktoriyel(n)
  Eger n <= 1 Ise Don 1; EgerBitti
  Don n * faktoriyel(n-1);
FonksiyonBitti

Yaz("5! = " + faktoriyel(5));
```

```
// Offline veritabanı — Türkçe SQL
Varyant db = VTOAc("okul");
VTCalistir(db, "TABLO_OLUSTUR EGER_YOKSA ogrenciler (id SAYI BIRINCAL_ANAHTAR OTOMATIK_ARTAN, ad METIN, not SAYI)");
VTCalistir(db, "EKLE ogrenciler (ad, not) DEGERLER (?, ?)", ["Ali", 95]);
Dizi sonuc = VTSorgu(db, "SEC HEPSI ogrenciler NEREDE not > ?", [80]);
Yaz(sonuc[0].ad);
VTKapat(db);
```

```
// Anonim fonksiyon
Dizi buyukler = DiziFiltrele([1,8,3,12,5], Fonksiyon(x)
  Don x > 5;
FonksiyonBitti);
Yaz(buyukler);  // [8, 12]
```

---

## Anahtar Kelime Karşılıkları

| Türkçe | İngilizce |
|---|---|
| `Sayi` | int |
| `Ondalik` | float |
| `Metin` | string |
| `Mantiksal` | boolean |
| `Dizi` | array |
| `Varyant` | var / any |
| `Eger...Ise...Degilse...EgerBitti` | if...else...end |
| `Dongu i = 0 To 10 Adim 1` | for i = 0 to 10 step 1 |
| `Suresince...SuresinceBitti` | while...end |
| `Tekrarla N Kez...TekrarlaBitti` | repeat N times |
| `Fonksiyon...FonksiyonBitti` | function...end |
| `Sinif...SinifBitti` | class...end |
| `Dene...Yakala...DeneBitti` | try...catch...end |
| `Don` | return |
| `Kes` | break |
| `Devam` | continue |
| `Yaz()` | print() |
| `Dogru / Yanlis` | true / false |
| `Ve / Veya / Degil` | and / or / not |
| `bos` | null |

---

## Emeği Geçenler

| Kişi / Araç | Katkı |
|---|---|
| **AcizBirKul (Kadir Çakmak)** | Özgün fikir, algoritma, tasarım kararları, proje yönetimi |
| **Claude (Anthropic)** | Geliştirme, mimari, uygulama |
| **DeepSeek** | Debug, test, geliştirme |

---

## 🇬🇧 English

### What is it?

TürkçeKod is a programming language and IDE built entirely in a single HTML file. It lets you write code using Turkish keywords and runs directly in any modern browser — no installation, no setup.

### What's new in v14?

- **5 themes** — VS2022 Dark (default), VS2022 Light, Monokai, Dracula, Solarized Dark
- **Splash screen** — project wizard on startup
- **Anonymous functions** — use `Fonksiyon()...FonksiyonBitti` anywhere, including as arguments and IIFE
- **Dual database system** — `VTAc` (SQLite, online) and `VTOAc` (Turkish SQL, offline, no internet needed)
- **Parameterized queries** — SQL injection protection with `?` placeholders
- **Library ecosystem** — `.tklib` package format, import/export, community sharing
- **Chain access** — `result[0].name`, `list[i].value` now works correctly
- **Better error messages** — human-readable, context-aware
- **Compiler fix** — compiled HTML only includes the interpreter, not the IDE
- **API Reference** — separate documentation site (`TurkceKod_API_Referans.html`)
- **Project save/load** — modules saved correctly, no unwanted `.json`/`.txt` extensions

### Usage

Open in your browser → [https://seyyidkadir.github.io/TurkceKod/](https://seyyidkadir.github.io/TurkceKod/)

Or download `turkceprogramlamaV14.html` and open it locally in any browser.

### Features

- ✅ Turkish syntax (`Eger`=if, `Dongu`=for, `Fonksiyon`=function, `Sayi`=int, `Metin`=string…)
- 🪟 GUI — Window, Button, Label, Canvas, Timer and more
- 🧙 Project Wizard — scaffold a new project in seconds
- 🖼️ Form Designer — drag-and-drop GUI builder
- 🎮 Game engine — 60fps loop, collision detection, input handling
- 🗄️ Database — SQLite online + Turkish SQL offline
- 📦 Library ecosystem — `.tklib` format
- 🎨 5 themes — VS2022 Dark/Light, Monokai, Dracula, Solarized
- 📖 API Reference — full documentation site

### Example

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
| **AcizBirKul (Kadir Çakmak)** | Original idea, algorithm, design decisions, project ownership |
| **Claude (Anthropic)** | Development, architecture, implementation |
| **DeepSeek** | Debug, testing, development |

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
| `Suresince...SuresinceBitti` | while...end |
| `Tekrarla N Kez...TekrarlaBitti` | repeat N times |
| `Fonksiyon...FonksiyonBitti` | function...end |
| `Sinif...SinifBitti` | class...end |
| `Dene...Yakala...DeneBitti` | try...catch...end |
| `Don` | return |
| `Kes` | break |
| `Devam` | continue |
| `Yaz()` | print() |
| `Dogru / Yanlis` | true / false |
| `Ve / Veya / Degil` | and / or / not |
| `bos` | null |

---

> 📁 The original 2012 source code is at `Original/Kod_Yorumla.cs` — written in high school 😊

> Hataları, eksik syntax'leri veya önerilerinizi lütfen GitHub üzerinden bildirin.
> Please report bugs, missing syntax or suggestions via GitHub Issues.

---

*© 2026 AcizBirKul (Kadir Çakmak) — TürkçeKod v14*
