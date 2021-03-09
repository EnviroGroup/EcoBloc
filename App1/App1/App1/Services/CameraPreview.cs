using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Services
{
    class public CameraPreview : View
    {
        public static readonly BindableProperty CameraProperty = BindableProperty.Create(propertyName: "Camera", returnType: typeof(CameraOptions), declaringType: typeof(CameraPreview), defaultValue: CameraOptions.Rear);
        public CameraOptions Camera
        {
            get
            {
                return (CameraOptions)GetValue(CameraProperty);
            }
            set
            {
                SetValue(CameraProperty, value);
            }
        }
    }
public enum CameraOptions
{
    Rear,
    Front
}
{
    public enum CameraOptions()

    }
}
