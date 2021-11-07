// Decompiled with JetBrains decompiler
// Type: Windows.Perception.People.IHeadPose
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.People
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2136655269, 18907, 14239, 148, 41, 50, 162, 250, 243, 79, 166)]
  [ExclusiveTo(typeof (HeadPose))]
  internal interface IHeadPose
  {
    Vector3 Position { get; }

    Vector3 ForwardDirection { get; }

    Vector3 UpDirection { get; }
  }
}
