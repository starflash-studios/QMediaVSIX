// Decompiled with JetBrains decompiler
// Type: Windows.UI.Accessibility.IScreenReaderService
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Accessibility
{
  [ExclusiveTo(typeof (ScreenReaderService))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(424104999, 60096, 20691, 189, 217, 155, 72, 122, 34, 98, 86)]
  internal interface IScreenReaderService
  {
    ScreenReaderPositionChangedEventArgs CurrentScreenReaderPosition { get; }

    event TypedEventHandler<ScreenReaderService, ScreenReaderPositionChangedEventArgs> ScreenReaderPositionChanged;
  }
}
