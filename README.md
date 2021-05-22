<h1 align="center">Darewro PDF<h2>
<h3 align="center">A program for Abasyn's Shaheens<h3>
<h3 align="center">By Tehseen Sajjad<h3>

<br>
<br>

# Download
* Check the release page here: [Release Page](https://github.com/tarpalantiri/Darewro_PDF/releases/tag/v0.5) for periodic updates.
* Or [Click this](https://github.com/tarpalantiri/Darewro_PDF/releases/download/v0.5/Darewro.exe) to start downloading directly.

# Installation
There is no setup just copy `Darewro.exe` to your desired directory

# Usage
* Create a folder and put
all your images in there.
* Copy `Darewro.exe` to that folder.
* Double click `Darewro.exe`
* Terminal/commandline window will open, follow the on screen
instructions.
* If you said `yes` to the `Have you made a front page`?
    * You should have a PDF made with your First Page info
    * The program will join `images.pdf` and `front page.pdf` into `final.pdf`
* If you said no
  * All your images will be merged into a single `images.pdf`
* Chalo mazay karo...

## FAQ
## I want to use this as a script coz im HACKERMANS

* You need two packages to run this script
* Pillow, used for `PIL` package.
* PyMuPdf, for merging multiple pdfs with the `fitz` package.

```
pip install pillow fitz wheel
```

* Then just copy the script to your iamges folder and
```
python main.py
```

## I ran the program, but i dont see any pdf?
* If there was any problem, the program creates a check `logs.txt` file.
* Whatsapp me the contents of that file.
