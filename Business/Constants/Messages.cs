﻿using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi";
        public static string CarDescriptionInvalid = "Araç ismi geçersiz";
        public static string MaintenanceTime="Sistem bakımda";
        public static string CarsListed="Araçlar listelendi";
        public static string CarsDeleted = "Araçlar silindi";
        public static string CarsUpdated = "Araçlar güncellendi";
        public static string BrandNameInvalid="Marka ismi geçersiz";
        public static string ColorNameInvalid="Renk geçersiz";
        public static string RentalDeleted="Kiralama işlemi silindi";
        public static string RentalAdded="Kiralama işlemi eklendi";
        public static string RentalUpdated="Kiralama işlemi güncellendi";
        public static string UserAdded="Kullanıcı eklendi";
        public static string UserDeleted="Kullanıcı silindi";
        public static string UserUpdated="Kullanıcı güncellendi";
        public static string CustomerAdded="Müşteri eklendi";

        public static string CarImageLimitExceeded="Resim ekleme limiti aşıldı";
        public static string AuthorizationDenied="Yetkiniz yok";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
    }
}
