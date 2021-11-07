// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.PersonPicture
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Contacts;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a control that displays the avatar image for a person, if one is available; if not, it displays the person's initials or a generic glyph.</summary>
  [Static(typeof (IPersonPictureStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Composable(typeof (IPersonPictureFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public class PersonPicture : Control, IPersonPicture
  {
    /// <summary>Initializes a new instance of the PersonPicture class.</summary>
    [MethodImpl]
    public extern PersonPicture();

    /// <summary>Gets or sets the contact number to display on the badge.</summary>
    /// <returns>The contact number to display on the badge.</returns>
    public extern int BadgeNumber { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Segoe MDL2 Assets font glyph to display on the badge.</summary>
    /// <returns>The hexadecimal character code for the badge glyph.</returns>
    public extern string BadgeGlyph { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the source of an image to display on the badge.</summary>
    /// <returns>An object that represents the image source file for the drawn image. Typically you set this with a BitmapImage object, constructed with the Uniform Resource Identifier (URI) that describes the path to a valid image source file. Or, you can initialize a BitmapSource with a stream, perhaps a stream from a storage file.</returns>
    public extern ImageSource BadgeImageSource { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the contact text to display on the badge.</summary>
    /// <returns>The contact text to display on the badge.</returns>
    public extern string BadgeText { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the PersonPicture represents a group or an individual.</summary>
    /// <returns>**true** if the PersonPicture represents a group; otherwise, **false**.</returns>
    public extern bool IsGroup { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Contact object that contains information about the person.</summary>
    /// <returns>A Contact object that contains information about the person.</returns>
    public extern Contact Contact { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the contact's display name.</summary>
    /// <returns>The contact's display name.</returns>
    public extern string DisplayName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the contact's initials.</summary>
    /// <returns>The contact's initials.</returns>
    public extern string Initials { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether a small image is displayed rather than a large image when both are available.</summary>
    /// <returns>**true** to display a small image even when a large image is available; otherwise, **false**. The default is **false**.</returns>
    public extern bool PreferSmallImage { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the source of the contact's profile picture.</summary>
    /// <returns>An object that represents the image source file for the drawn image. Typically you set this with a BitmapImage object, constructed with the Uniform Resource Identifier (URI) that describes the path to a valid image source file. Or, you can initialize a BitmapSource with a stream, perhaps a stream from a storage file.</returns>
    public extern ImageSource ProfilePicture { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the BadgeNumber dependency property.</summary>
    /// <returns>The identifier for the BadgeNumber dependency property.</returns>
    public static extern DependencyProperty BadgeNumberProperty { [MethodImpl] get; }

    /// <summary>Identifies the BadgeGlyph dependency property.</summary>
    /// <returns>The identifier for the BadgeGlyph dependency property.</returns>
    public static extern DependencyProperty BadgeGlyphProperty { [MethodImpl] get; }

    /// <summary>Identifies the BadgeImageSource dependency property.</summary>
    /// <returns>The identifier for the BadgeImageSource dependency property.</returns>
    public static extern DependencyProperty BadgeImageSourceProperty { [MethodImpl] get; }

    /// <summary>Identifies the BadgeText dependency property.</summary>
    /// <returns>The identifier for the BadgeText dependency property.</returns>
    public static extern DependencyProperty BadgeTextProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsGroup dependency property.</summary>
    /// <returns>The identifier for the IsGroup dependency property.</returns>
    public static extern DependencyProperty IsGroupProperty { [MethodImpl] get; }

    /// <summary>Identifies the Contact dependency property.</summary>
    /// <returns>The identifier for the Contact dependency property.</returns>
    public static extern DependencyProperty ContactProperty { [MethodImpl] get; }

    /// <summary>Identifies the DisplayName dependency property.</summary>
    /// <returns>The identifier for the DisplayName dependency property.</returns>
    public static extern DependencyProperty DisplayNameProperty { [MethodImpl] get; }

    /// <summary>Identifies the Initials dependency property.</summary>
    /// <returns>The identifier for the Initials dependency property.</returns>
    public static extern DependencyProperty InitialsProperty { [MethodImpl] get; }

    /// <summary>Identifies the PreferSmallImage dependency property.</summary>
    /// <returns>The identifier for the PreferSmallImage dependency property.</returns>
    public static extern DependencyProperty PreferSmallImageProperty { [MethodImpl] get; }

    /// <summary>Identifies the ProfilePicture dependency property.</summary>
    /// <returns>The identifier for the ProfilePicture dependency property.</returns>
    public static extern DependencyProperty ProfilePictureProperty { [MethodImpl] get; }
  }
}
