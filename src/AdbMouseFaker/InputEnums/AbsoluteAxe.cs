namespace AdbMouseFaker.InputEnums;

// ReSharper disable InconsistentNaming
public enum AbsoluteAxe
{
    ABS_X              = 0x00,
    ABS_Y              = 0x01,
    ABS_Z              = 0x02,
    ABS_RX             = 0x03,
    ABS_RY             = 0x04,
    ABS_RZ             = 0x05,
    ABS_THROTTLE       = 0x06,
    ABS_RUDDER         = 0x07,
    ABS_WHEEL          = 0x08,
    ABS_GAS            = 0x09,
    ABS_BRAKE          = 0x0a,
    ABS_HAT0X          = 0x10,
    ABS_HAT0Y          = 0x11,
    ABS_HAT1X          = 0x12,
    ABS_HAT1Y          = 0x13,
    ABS_HAT2X          = 0x14,
    ABS_HAT2Y          = 0x15,
    ABS_HAT3X          = 0x16,
    ABS_HAT3Y          = 0x17,
    ABS_PRESSURE       = 0x18,
    ABS_DISTANCE       = 0x19,
    ABS_TILT_X         = 0x1a,
    ABS_TILT_Y         = 0x1b,
    ABS_TOOL_WIDTH     = 0x1c,

    ABS_VOLUME         = 0x20,
    
    ABS_MISC           = 0x28,
    
    [Obsolete("Reserved and should not be used in input drivers. It was used by HID as ABS_MISC+6 and userspace needs to detect if the next ABS_* event is correct or is just ABS_MISC + n. We define here ABS_RESERVED so userspace can rely on it and detect the situation described above.", error: true)]
    ABS_RESERVED       = 0x2e,
    
    ABS_MT_SLOT        = 0x2f,
    ABS_MT_TOUCH_MAJOR = 0x30,
    ABS_MT_TOUCH_MINOR = 0x31,
    ABS_MT_WIDTH_MAJOR = 0x32,
    ABS_MT_WIDTH_MINOR = 0x33,
    ABS_MT_ORIENTATION = 0x34,
    ABS_MT_POSITION_X  = 0x35,
    ABS_MT_POSITION_Y  = 0x36,
    ABS_MT_TOOL_TYPE   = 0x37,
    ABS_MT_BLOB_ID     = 0x38,
    ABS_MT_TRACKING_ID = 0x39,
    ABS_MT_PRESSURE    = 0x3a,
    ABS_MT_DISTANCE    = 0x3b,
    ABS_MT_TOOL_X      = 0x3c,
    ABS_MT_TOOL_Y      = 0x3d,
    
    ABS_MAX            = 0x3f,
    ABS_CNT            = ABS_MAX +1,
}
