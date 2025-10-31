# CvSiteNet9_Modern (ASP.NET Core 9 MVC)

Modern, koyu/açık tema destekli CV/Portföy sitesi.
- Cam efekti (glass), gradient vurgular, chip’ler, hover-lift mikro etkileşimleri
- Karanlık/Aydınlık tema (kalıcı, localStorage)
- Scroll ile görünür olma animasyonu (IntersectionObserver)
- Bootstrap 5 + özel modern CSS

## Çalıştırma
```bash
cd CvSiteNet9_Modern
dotnet restore
dotnet run
```

## Yayınlama
```bash
# Framework-dependent
dotnet publish -c Release -o out

# Self-contained (Apple Silicon macOS):
dotnet publish -c Release -r osx-arm64 --self-contained true -p:PublishSingleFile=true -o out
./out/CvSiteNet9_Modern
```
