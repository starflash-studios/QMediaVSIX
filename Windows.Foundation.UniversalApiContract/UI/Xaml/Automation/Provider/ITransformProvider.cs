// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.ITransformProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Exposes methods and properties to support access by a Microsoft UI Automation client to controls or elements that can be moved, resized, or rotated within a two-dimensional space. Implement this interface in order to support the capabilities that an automation client requests with a GetPattern call and PatternInterface.Transform.</summary>
  [Guid(2036797405, 63145, 19045, 175, 23, 134, 29, 183, 153, 162, 218)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ITransformProvider
  {
    /// <summary>Gets a value that indicates whether the element can be moved.</summary>
    /// <returns>**true** if the element can be moved; otherwise, **false**.</returns>
    bool CanMove { get; }

    /// <summary>Gets a value that indicates whether the element can be resized.</summary>
    /// <returns>**true** if the element can be resized; otherwise, **false**.</returns>
    bool CanResize { get; }

    /// <summary>Gets a value that indicates whether the element can be rotated.</summary>
    /// <returns>**true** if the element can be rotated; otherwise, **false**.</returns>
    bool CanRotate { get; }

    /// <summary>Moves the control.</summary>
    /// <param name="x">The absolute screen coordinates of the left side of the control.</param>
    /// <param name="y">The absolute screen coordinates of the top of the control.</param>
    void Move(double x, double y);

    /// <summary>Resizes the control.</summary>
    /// <param name="width">The new width of the window, in pixels.</param>
    /// <param name="height">The new height of the window, in pixels.</param>
    void Resize(double width, double height);

    /// <summary>Rotates the control.</summary>
    /// <param name="degrees">The number of degrees to rotate the control. A positive number rotates the control clockwise. A negative number rotates the control counterclockwise.</param>
    void Rotate(double degrees);
  }
}
