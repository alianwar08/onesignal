using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Backend.EF
{
    public class App
    {
        [Key]
        public string id { get; set; }

        [StringLength(250)]
        public string name { get; set; }

        [StringLength(250)]
        public string gcm_key { get; set; }

        [StringLength(250)]
        public string chrome_key { get; set; }

        [StringLength(250)]
        public string chrome_web_key { get; set; }

        [StringLength(250)]
        public string chrome_web_origin { get; set; }

        [StringLength(250)]
        public string chrome_web_gcm_sender_id { get; set; }

        [StringLength(250)]
        public string chrome_web_default_notification_icon { get; set; }

        [StringLength(250)]
        public string chrome_web_sub_domain { get; set; }

        [StringLength(250)]
        public string apns_env { get; set; }

        [StringLength(250)]
        public string apns_certificates { get; set; }
        
        [StringLength(250)]
        public string safari_apns_certificate { get; set; }
        
        [StringLength(250)]
        public string safari_site_origin { get; set; }
        
        [StringLength(250)]
        public string safari_push_id { get; set; }
        
        [StringLength(250)]
        public string safari_icon_16_16 { get; set; }
        
        [StringLength(250)]
        public string safari_icon_32_32 { get; set; }
        
        [StringLength(250)]
        public string safari_icon_64_64 { get; set; }
        
        [StringLength(250)]
        public string safari_icon_128_128 { get; set; }
        
        [StringLength(250)]
        public string safari_icon_256_256 { get; set; }
        
        [StringLength(250)]
        public string site_name { get; set; }
        
        public DateTime? created_at { get; set; }
        
        public DateTime? updated_at { get; set; }
        
        public int? players { get; set; }
        
        public int? messageable_players { get; set; }
        
        [StringLength(250)]
        public string basic_auth_key { get; set; }

        [StringLength(250)]
        public string additional_data_is_root_payload { get; set; }

        public DateTime? synch_at { get; set; }

    }
}
