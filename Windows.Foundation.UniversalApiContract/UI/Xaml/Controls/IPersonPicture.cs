// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPersonPicture
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Contacts;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (PersonPicture))]
  [Guid(1814236013, 3445, 16473, 145, 188, 123, 23, 77, 29, 115, 21)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  internal interface IPersonPicture
  {
    int BadgeNumber { get; set; }

    string BadgeGlyph { get; set; }

    ImageSource BadgeImageSource { get; set; }

    string BadgeText { get; set; }

    bool IsGroup { get; set; }

    Contact Contact { get; set; }

    string DisplayName { get; set; }

    string Initials { get; set; }

    bool PreferSmallImage { get; set; }

    ImageSource ProfilePicture { get; set; }
  }
}
