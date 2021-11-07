// Decompiled with JetBrains decompiler
// Type: Windows.UI.Accessibility.IScreenReaderPositionChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Accessibility
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(1434367461, 21712, 23757, 159, 197, 237, 51, 53, 127, 138, 159)]
  [ExclusiveTo(typeof (ScreenReaderPositionChangedEventArgs))]
  internal interface IScreenReaderPositionChangedEventArgs
  {
    Rect ScreenPositionInRawPixels { get; }

    bool IsReadingText { get; }
  }
}
