# Steganography

The art of hiding information in plain sight. Unlike encryption, where it's obvious that a message is being hidden, steganography hides data in plain view, inside a file such as a picture. As far as images are concerned, to anyone who isn't aware that it contains hidden data, it looks like just a normal, innocent picture.
 
## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes, but also with short description of the implementation.

### Prerequisites

* [Microsoft Visual Studio](https://visualstudio.microsoft.com/) - Full-featured IDE used to code, debug, test and deploy.

### Technologies

* .NET Framework 4.7.2
* MetroSetUI
* MaterialSkin

## Installation

### Clone

* Clone this repo to your local machine using https://github.com/mbarosevic/steganography.git

Start the project and run it.

## Demo

One of the most widely used steganography techniques is the least significant bit technique, known commonly as LSB. This technique changes the last few bits in a byte to encode a message, which is especially useful in something like an image, where the red, green, and blue values of each pixel are represented by eight bits (one byte) ranging from 0 to 255 in decimal or 00000000 to 11111111 in binary.

The diagram shows two 4-pixel images in both color and binary values. Each block of binary represents the value of the corresponding pixel.
![LSBTechnique](https://img.wonderhowto.com/img/original/02/61/63645877844452/0/636458778444520261.jpg)


As changing the last two bits in a completely red pixel from 11111111 to 11111101 only changes the red value from 255 to 253, which to the naked eye creates a nearly imperceptible change in color but still allows us to encode data inside of the picture.

For this example I used a simple white image to show how the LSB techinque change the pixel value.

Yellow pixels are the ones where the data is encoded.
![Recordit GIF](https://recordit.co/6BG9Ff4dxj.gif)
```
Give the example
```

And repeat

```
until finished
```

End with an example of getting some data out of the system or using it for a little demo

## Built With

* [Microsoft Visual Studio](https://visualstudio.microsoft.com/) - Full-featured IDE used to code, debug, test and deploy.
* [MetroSet-UI](https://github.com/N-a-r-w-i-n/MetroSet-UI) - Windows Forms Metro Skin Style
* [ROME](https://rometools.github.io/rome/) - Used to generate RSS Feeds

## Acknowledgments

* [Wonder How To](https://www.wonderhowto.com/)
* [Cryptii](https://cryptii.com/pipes/aes-encryption)
* [Daniel's Dev Blog - AES-256 Encryption](https://odan.github.io/2017/08/10/aes-256-encryption-and-decryption-in-php-and-csharp.html)
