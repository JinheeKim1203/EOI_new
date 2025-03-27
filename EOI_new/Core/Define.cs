using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace EOI_new.Core
{
    //#MODEL#1 InspWindowType 정의
    public enum InspWindowType
    {
        None = 0,
        Global,
        ID,
        Pin,
        Chip,
        Lead,
        Group
    }

    public enum NetworkType
    { 
        None = 0,
        WCF
    }


    internal class Define
    {
        //# SAVE ROI#4 전역적으로, ROI 저장 파일명을 설정
        //Define.cs 클래스 생성 먼저 할것
        //public static readonly string ROI_IMAGE_NAME = "RoiImage.png";

        public static readonly string TEMPLATE_FOLDER = "Template";

        public static string GetTemplateFolderPath()
        {
            string folder = Path.Combine(Directory.GetCurrentDirectory(), TEMPLATE_FOLDER);
            Directory.CreateDirectory(folder);
            return folder;

        }

        public static string GetTemplateFilePathFromUid(string uid)
        {
            string folder = GetTemplateFolderPath();
            string filePath = Path.Combine(folder, $"{uid}.jpg");
            return filePath;
        }

        public static List<Mat> LoadTemplateListByUid(string uid)
        {
            string folder = GetTemplateFolderPath();
            string[] files = Directory.GetFiles(folder, $"{uid}_*.jpg");

            List<Mat> templates = new List<Mat>();
            foreach (var file in files)
            {
                Mat img = Cv2.ImRead(file);
                if (img != null && !img.Empty())
                {
                    templates.Add(img);
                }
            }

            return templates;
        }

        public static string GetNextTemplateFilePath(string uid)
        {
            string folder = GetTemplateFolderPath();
            int index = 1;
            string path;

            do
            {
                string fileName = $"{uid}_{index}.jpg";
                path = Path.Combine(folder, fileName);
                index++;
            } while (File.Exists(path));

            return path;
        }
    }
}
