#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Windows.Media.Imaging;

#endregion

namespace QMediaVSIX.Environment {
  public static class Images {

    public static BitmapImage UnknownThumbnail;

    // ReSharper disable once ArrangeConstructorOrDestructorBody
    static Images() {
      //new BitmapImage(new Uri("/QMediaVSIX;component/Resources/imageres_15.ico"));
      //Icon? Ico = Resources.imageres_15;
      //Debug.WriteLine(Ico is null);
      //BitmapSource? ImgSource = Ico?.ToBitmapSource();
      //Debug.WriteLine(ImgSource is null);
      //BitmapImage? BmpImg = ImgSource?.ToBitmapImage<PngBitmapEncoder>(); //<-- Works up until here.
      //Debug.WriteLine(BmpImg is null);
      //UnknownThumbnail = BmpImg ?? throw new ArgumentNullException(nameof(Resources.imageres_15));
      //ImagesResources IR = new ImagesResources();
      //UnknownThumbnail = ((Image)IR.Resources["Imageres15"]).Source;
      UnknownThumbnail = new BitmapImage(new Uri("../Resources/imageres_15.ico", UriKind.Relative));
      //UnknownThumbnail = new 
    }

  }
}
