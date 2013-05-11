using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YamSharp.Model
{
    class User
    {
    }

    public class Stats
    {
        public int following { get; set; }
        public int updates { get; set; }
        public int followers { get; set; }
    }

    public class Settings
    {
        public string xdr_proxy { get; set; }
    }

    public class Im
    {
        public string provider { get; set; }
        public string username { get; set; }
    }

    public class PhoneNumber
    {
        public string type { get; set; }
        public string number { get; set; }
    }

    public class EmailAddress
    {
        public string address { get; set; }
        public string type { get; set; }
    }

    public class Contact
    {
        public Im im { get; set; }
        public bool has_fake_email { get; set; }
        public List<PhoneNumber> phone_numbers { get; set; }
        public List<EmailAddress> email_addresses { get; set; }
    }

    public class School
    {
        public string description { get; set; }
        public string degree { get; set; }
        public int end_year { get; set; }
        public int start_year { get; set; }
        public string school { get; set; }
    }

    public class NetworkSettings
    {
        public bool allow_yammer_apps { get; set; }
        public bool show_communities_directory { get; set; }
        public bool allow_external_sharing { get; set; }
        public bool allow_inline_document_view { get; set; }
        public bool enable_chat { get; set; }
        public bool enable_groups { get; set; }
        public string admin_can_delete_messages { get; set; }
        public string message_prompt { get; set; }
        public string allow_attachments { get; set; }
        public bool enable_private_messages { get; set; }
        public bool allow_inline_video { get; set; }
    }

    public class HomeTab
    {
        public string name { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public string select_name { get; set; }
        public string ordering_index { get; set; }
        public string feed_description { get; set; }
        public int? group_id { get; set; }
        public bool? @private { get; set; }
    }

    public class WebPreferences
    {
        public string preferred_my_feed { get; set; }
        public NetworkSettings network_settings { get; set; }
        public bool dismissed_apps_tooltip { get; set; }
        public string dismissed_invite_tooltip_at { get; set; }
        public string absolute_timestamps { get; set; }
        public bool sticky_my_feed { get; set; }
        public string prescribed_my_feed { get; set; }
        public bool dismissed_invite_tooltip { get; set; }
        public string enable_chat { get; set; }
        public bool dismissed_profile_prompt { get; set; }
        public string threaded_mode { get; set; }
        public bool dismissed_feed_tooltip { get; set; }
        public bool dismissed_group_tooltip { get; set; }
        public string enter_does_not_submit_message { get; set; }
        public List<HomeTab> home_tabs { get; set; }
        public string show_full_names { get; set; }
    }

    public class RootObject
    {
        public Stats stats { get; set; }
        public int id { get; set; }
        public Settings settings { get; set; }
        public string birth_date { get; set; }
        public string state { get; set; }
        public Contact contact { get; set; }
        public string mugshot_url { get; set; }
        public List<string> external_urls { get; set; }
        public string can_broadcast { get; set; }
        public string significant_other { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string verified_admin { get; set; }
        public List<string> network_domains { get; set; }
        public string location { get; set; }
        public string interests { get; set; }
        public string network_name { get; set; }
        public string url { get; set; }
        public List<object> previous_companies { get; set; }
        public string first_name { get; set; }
        public int network_id { get; set; }
        public string department { get; set; }
        public string full_name { get; set; }
        public string admin { get; set; }
        public string mugshot_url_template { get; set; }
        public bool show_ask_for_photo { get; set; }
        public List<School> schools { get; set; }
        public WebPreferences web_preferences { get; set; }
        public string web_url { get; set; }
        public string job_title { get; set; }
        public string timezone { get; set; }
        public string summary { get; set; }
        public object hire_date { get; set; }
        public object guid { get; set; }
        public bool follow_general_messages { get; set; }
        public string activated_at { get; set; }
        public string expertise { get; set; }
        public string last_name { get; set; }
        public string kids_names { get; set; }
    }

}
